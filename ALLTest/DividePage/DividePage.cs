using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DividePage
{
    public class Divide<T>:IDisposable
        where T:class
    {
        private string tempFloder = AppDomain.CurrentDomain.BaseDirectory;

        private string nowBlockPath = "BaseLocation";
        private int blockCount = 0;//块文件个数
        private List<DivideLocation> pagesLocation = new List<DivideLocation>();
        private int blockSize = 5000000;//0x1e00000;//30m
        private MemoryStream baseStream = new MemoryStream();


        public string TempFloder
        {
            get { return tempFloder; }
            set { tempFloder = value; }
        }
        public T GetPage(int page)
        {
            var loc=pagesLocation.Find(x => x.PageNumber == page);
            if (loc==null)
            {
                return null;
            }
            return ReadPage(loc);
        }

        public bool SetPage(T page,int PageNumber)
        {
            var same=pagesLocation.Where(x => x.PageNumber == PageNumber).Count();
            if (same>0)
            {
                return false;
            }
            var location = SavePage(page, PageNumber);
            pagesLocation.Add(location);
            return true;
        }

        private T ReadPage(DivideLocation page)
        {
            BinaryFormatter xmlser = new BinaryFormatter();
            MemoryStream tms = new MemoryStream();
            byte[] tempdata = new byte[page.Location.Length];
            if (page.LocationPath.Equals(nowBlockPath))
            {
                baseStream.Position = page.Location.StartLoctation;
                int count=baseStream.Read(tempdata,0, page.Location.Length);
                baseStream.Seek(0, SeekOrigin.End);
            }
            else
            {
                var blocldata=FileToStream(page.LocationPath);
                blocldata.Position = page.Location.StartLoctation;
                blocldata.Read(tempdata, 0, page.Location.Length);
                blocldata.Close();
            }
            tms.Write(tempdata, 0, tempdata.Length);
            tms.Seek(0, SeekOrigin.Begin);
            return xmlser.Deserialize(tms) as T;

        }

        private DivideLocation SavePage(T page, int PageNumber)
        {
            DivideLocation divlocation = new DivideLocation();
            try
            {
                divlocation.PageNumber = PageNumber;
                divlocation.Location.StartLoctation = (int)baseStream.Position;
                BinaryFormatter xmlser = new BinaryFormatter();
                xmlser.Serialize(baseStream, page);
                divlocation.Location.Length = (int)(baseStream.Position - divlocation.Location.StartLoctation);
                divlocation.LocationPath = nowBlockPath;
                if (baseStream.Length > blockSize)
                {
                    blockCount++;
                    var temppath = StreamToFile(baseStream, blockCount);
                    for (int i = 0; i < pagesLocation.Count; i++)
                    {
                        if (pagesLocation[i].LocationPath.Equals(nowBlockPath))
                        {
                            pagesLocation[i].LocationPath = temppath;
                        }
                    }
                    baseStream.Seek(0, SeekOrigin.Begin);
                    baseStream.Close();
                    baseStream = new MemoryStream();
                }
            }
            catch (Exception e)
            {
                throw;
            }
                return divlocation;
            
        }

        private string StreamToFile(Stream stream,int Number)
        {
            string path=TempFloder + "//Block" + Number.ToString();
            FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.Write);
            byte[] data=new byte[stream.Length];
            //stream.Read(data,0,(int)stream.Length);
            //filestream.Write(data, 0, data.Length);
            baseStream.WriteTo(filestream);
            filestream.Flush();
            filestream.Close();
            stream.Seek(0, SeekOrigin.Begin);
            return path;
        }

        private Stream FileToStream(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return fileStream;
        }

        #region IDisposable 成员

        public void Dispose()
        {
            var locations=pagesLocation.GroupBy(x => x.LocationPath);
            foreach (var item in locations)
            {
                if (!item.Key.Equals(nowBlockPath))
                {
                    File.Delete(item.Key);
                }
                
            }
            baseStream.Close();
            //throw new NotImplementedException();
        }

        #endregion
    }

    public class DivideLocation
    {
        public int PageNumber;
        public string LocationPath;
        public StreamLoctaion Location=new StreamLoctaion();
    }

    public class StreamLoctaion
	{
        public int StartLoctation;
        public int Length;
	}
}

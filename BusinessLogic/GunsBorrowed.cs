using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataHandler;
using System.Threading.Tasks;
using System.Data;

namespace BusinessLogic
{
    public class GunsBorrowed
    {
        private int gunID;
        private bool band;
        private bool raiserBlock;
        private string dayOut;
        private int shooterID;

        public int GunID { get => gunID; set => gunID = value; }
        public bool Band { get => band; set => band = value; }
        public bool RaiserBlock { get => raiserBlock; set => raiserBlock = value; }
        public string DayOut { get => dayOut; set => dayOut = value; }
        public int ShooterID { get => shooterID; set => shooterID = value; }

        public GunsBorrowed(int gunID, bool band, bool raiserBlock, string dayOut, int shooterID)
        {
            this.gunID = gunID;
            this.band = band;
            this.raiserBlock = raiserBlock;
            this.dayOut = dayOut;
            this.shooterID = shooterID;
        }

        public GunsBorrowed() { }
        public List<GunsBorrowed> ReadData()
        {
            List<GunsBorrowed> GunList = new List<GunsBorrowed>();
            DataSet rawData = new DBAccess().ReadDataFromDB("tblGunsBorrowed");
            foreach (DataRow item in rawData.Tables["tblGunsBorrowed"].Rows)
            {
                GunList.Add(new GunsBorrowed(int.Parse(item["GunID"].ToString()),
                    bool.Parse(item["Band"].ToString()),
                    bool.Parse(item["RaiserBlock"].ToString()),
                    item["DayOut"].ToString(),
                    int.Parse(item["ShooterID"].ToString())));
            }
            return GunList;
        }

        public List<Guns> AvailableGuns()
        {
            List<Guns> GunList = new List<Guns>();
            DataSet rawData = new DBAccess().AvailableGuns();
            foreach (DataRow item in rawData.Tables["tblGuns"].Rows)
            {
                GunList.Add(new Guns(int.Parse(item["GunID"].ToString()),
                    item["Manufacturer"].ToString(),
                    item["Model"].ToString(),
                    item["Condition"].ToString(),
                    item["Comments"].ToString(),
                    item["SerialNumber"].ToString()));
            }
            return GunList;
        }

        public void Insert(int GunID, bool raiserblok, bool band, int shooterid, string dayout)
        {
            new DBAccess().InsertBorrowedGunData(GunID, band, raiserblok, shooterid, dayout);
        }

        public void delete(int id)
        {
            new DBAccess().DeleteBorrowedGunData(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHandler;
using System.Data;

namespace BusinessLogic
{
    public class Guns
    {
        private int gunID;
        private string manufacturer;
        private string model;
        private string condition;
        private string comments;
        private string serialNum;

        public int GunID { get => gunID; set => gunID = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string SerialNum { get => serialNum; set => serialNum = value; }
        public string Model { get => model; set => model = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Comments { get => comments; set => comments = value; }

        public Guns(int gunID, string manufacturer, string model, string condition, string comments, string serialNum)
        {
            this.gunID = gunID;
            this.manufacturer = manufacturer;
            this.model = model;
            this.condition = condition;
            this.comments = comments;
            this.serialNum = serialNum;
        }

        public Guns() { }

        public List<Guns> ReadData()
        {
            List<Guns> GunList = new List<Guns>();
            DataSet rawData = new DBAccess().ReadDataFromDB("tblGuns");
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

        public void InsertGunData(string manufacturer, string model, string condition, string comments, string serialNum)
        {
            new DBAccess().InsertGunData(manufacturer, model, condition, comments,serialNum);
        }

        public void UpdateData(int id, string manufacturer, string model, string condition, string comments, string serialNum)
        {
            new DBAccess().UpdateGunData(id, manufacturer, model, condition, comments, serialNum);
        }
        public void DeleteData(int id)
        {
            new DBAccess().DeleteGunData(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataHandler;
using System.Data;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Shooters
    {
        private int childID;
        private string name;
        private string surname;
        private string iDnumber;
        private string phone;
        private string email;
        private string parentName;
        private string parentEmail;
        private string parentPhone;
        private string notes;
        private bool scope;
        private bool tripod;
        private bool mat;
        private bool kneeRoll;



        public Shooters() { }

        public int ChildID { get => childID; set => childID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string IDNumber { get => iDnumber; set => iDnumber = value; }
        public string Email { get => email; set => email = value; }
        public string ParentName { get => parentName; set => parentName = value; }
        public string ParentEmail { get => parentEmail; set => parentEmail = value; }
        public string ParentPhone { get => parentPhone; set => parentPhone = value; }
        public string Notes { get => notes; set => notes = value; }
        public bool Scope { get => scope; set => scope = value; }
        public bool Tripod { get => tripod; set => tripod = value; }
        public bool Mat { get => mat; set => mat = value; }
        public bool KneeRoll { get => kneeRoll; set => kneeRoll = value; }


        public Shooters(int childID, string name, string surname, string iDnumber, string phone, string email, string parentName, string parentEmail, string parentPhone, string notes, bool scope, bool tripod, bool mat, bool kneeRoll)
        {
            this.childID = childID;
            this.name = name;
            this.surname = surname;
            this.iDnumber = iDnumber;
            this.phone = phone;
            this.email = email;
            this.parentName = parentName;
            this.parentEmail = parentEmail;
            this.parentPhone = parentPhone;
            this.notes = notes;
            this.scope = scope;
            this.tripod = tripod;
            this.mat = mat;
            this.kneeRoll = kneeRoll;
        }

        public List<Shooters> ReadData()
        {
            List<Shooters> ShooterList = new List<Shooters>();
            DataSet rawData = new DBAccess().ReadDataFromDB("tblShooters");
            foreach (DataRow item in rawData.Tables["tblShooters"].Rows)
            {
                ShooterList.Add(new Shooters(int.Parse(item["ShooterID"].ToString()),
                    item["ShooterName"].ToString(),
                    item["Surname"].ToString(),
                    item["Phone"].ToString(),
                    item["IDNumber"].ToString(),
                    item["Email"].ToString(),
                    item["ParentName"].ToString(),
                    item["ParentEmail"].ToString(),
                    item["ParentPhone"].ToString(),
                    item["Notes"].ToString(),
                    bool.Parse(item["Scope"].ToString()),
                    bool.Parse(item["Tripod"].ToString()),
                    bool.Parse(item["Mat"].ToString()),
                    bool.Parse(item["KneeRoll"].ToString())));
            }
            return ShooterList;
        }

        public void InsertShooter(string name, string surname,string phone, string iDnumber, string email, string parentName, string parentEmail, string parentPhone, string notes, bool scope, bool tripod, bool mat, bool kneeRoll)
        {
            new DBAccess().InsertNewShooter(name, surname, phone, iDnumber, email, parentName, parentEmail, parentPhone, notes, scope, tripod, mat, kneeRoll);
        }

        public void UpdateShooter(int id, string name, string surname, string phone, string iDnumber, string email, string parentName, string parentEmail, string parentPhone, string notes, bool scope, bool tripod, bool mat, bool kneeRoll)
        {
            new DBAccess().UpdateShooter(id, name, surname, phone, iDnumber, email, parentName, parentEmail, parentPhone, notes, scope, tripod, mat, kneeRoll);
        }

        public void DeleteShooter(int id)
        {
            new DBAccess().DeleteShooter(id);
        }
    }
}

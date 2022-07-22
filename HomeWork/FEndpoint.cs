using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class FEndpoint : RepoEndpoint
    {
        /* ############# LOAD LIST ############# */ // ----------------------- OK
        public static List<Endpoint> listEndpoint = new List<Endpoint>();

        public bool theListIsEmpty()
        {
            return listEndpoint.Count == 0;
        }

        public int getListSize() {

            return listEndpoint.Count;
        }
        /* ############# INSERT ############# */ // ----------------------- OK
        public bool Insert(Endpoint ep)
        {
            bool val = false;
            //validar se existe SN do endpoint na lista
            if (listEndpoint.Any(x => x.SerialNumber == ep.SerialNumber))
            {
                val = true;
            }

            if (val == true)
            {
                return false;
            }
            else
            {
                listEndpoint.Add(ep);
                return true;
            }
            //throw new NotImplementedException();
        }

        /* ############# EDIT ############# */ // ----------------------- OK
        public bool Edit(Endpoint ep)
        {
            if (listEndpoint.Any(x => x.SerialNumber == ep.SerialNumber)) {
                listEndpoint.Update(x => x.SwitchState = ep.SwitchState);
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        /* ############# DELETE ############# */ // ----------------------- OK
        public bool validDelete(string sNID) {
            if (!listEndpoint.Any(x => x.SerialNumber == sNID))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool Delete(string sNID)
        {
            var itemDel = listEndpoint.First(x => x.SerialNumber == sNID);
            listEndpoint.Remove(itemDel);
            return true;
            //throw new NotImplementedException();
        }

        /* ############# LIST ALL ############# */ // ----------------------- OK
        public List<Endpoint> ListAll()
        {
            return listEndpoint;
            //throw new NotImplementedException();
        }

        /* ############# FIND by SERIAL NUMBER ############# */ // ----------------------- OK
        public Endpoint Find(string sNID)
        {
                return listEndpoint.FirstOrDefault(p => p.SerialNumber == sNID);
        }

        /* ############# GET METER MODEL STRING ############# */ // ----------------------- OK
        public string getMMString(int ID)
        {
            string lblMM = "";
            if (ID == 16)
            {
                lblMM = "NSX1P2W";
            }else if (ID == 17)
            {
                lblMM = "NSX1P3W";
            }else if (ID == 18)
            {
                lblMM = "NSX2P3W";
            }else if (ID == 19){
                lblMM = "NSX3P4W";
            }
            return lblMM;
            //throw new NotImplementedException();
        }

        /* ############# SET METER MODEL ID ############# */ // ----------------------- OK
        public int setMMID(string ID)
        {
            int setID  = 0;
            if (ID == "NSX1P2W")
            {
                setID = 16;
            }else if (ID == "NSX1P3W")
            {
                setID = 17;
            }else if (ID == "NSX2P3W") {
                setID = 18;
            }else if(ID == "NSX3P4W")
            {
                setID= 19;
            }
            return setID;
            //throw new NotImplementedException();
        }

        /* ############# GET SWITCH STATE ############# */ // ----------------------- OK
        public string getSS(int ss)
        {
            string lblSS = "";
            if(ss == 0)
            {
                lblSS = "Disconnected";
            }else if(ss == 1)
            {
                lblSS = "Connected";
            }else if(ss == 2)
            {
                lblSS = "Armed";
            }

            return lblSS;
            //throw new NotImplementedException();
        }

    }

    public static class LinqUpdates
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source) { action(item); }
        }
    }
}

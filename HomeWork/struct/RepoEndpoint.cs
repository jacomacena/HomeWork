﻿namespace HomeWork
{
    interface RepoEndpoint
    {
        List<Endpoint> ListAll();
        bool Insert(Endpoint ep);
        Endpoint Find(string sNID);
        bool Edit(Endpoint ep);
        bool Delete(string sNID);
        string getSS(int ss);
        int setMMID(string ID);
        string getMMString(int ID);

    }
}

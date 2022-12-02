using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tickets;

namespace Lab6.Interfaces
{
    public interface iDownloader
    {
        object Download(string path);
    }
}
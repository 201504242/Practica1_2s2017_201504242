using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEscritorio
{
    class mensaje
    {
        private String ip;
        private String texto;

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
            }
        }

        public mensaje(string ip, string texto)
        {
            this.Ip = ip;
            this.Texto = texto;
        }
    }
}

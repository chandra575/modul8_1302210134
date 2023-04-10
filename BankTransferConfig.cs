using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modul8_1302210134
{
    public class Transfer
    {
        public Transfer(int threshold, int low_fee, int high_fee)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }

        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    public class Confirmation
    {
        public Confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }

        public string en { get; set; }
        public string id { get; set; }
    }


    public class BankTransferConfig
    {
        public Transfer transfer { get; set; }
        public Confirmation confirmation { get; set; }
        public string lang { get; set; }
       
        public string method { get; set; }

        public BankTransferConfig(string lang,int threshold,int low_fee,int high_fee,string method,string en,string id)
        {
            this.lang = lang;
            this.transfer = new Transfer(threshold, low_fee, high_fee);
            this.method = method;
            this.confirmation = new Confirmation(en, id);
        }

    }

    public class BankTC
    {
        public BankTransferConfig BTC { get; set; }
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string bankconfig = "bank_transfer_config.JSON";
        public BankTC()
        {
            try
            {
                ReadConfig();
            }
            catch
            {

            }
        }


        private BankTransferConfig ReadConfig()
        {
            
        }

    }
}

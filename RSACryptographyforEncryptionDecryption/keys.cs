﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSACryptographyforEncryptionDecryption
{
    public class keys
    {
        public string message { get; set; }
        public double messageToBeEncrypted { get; set; }
        public double encryptedMessage { get; set; }
        public long messageToBeDecryted { get; set; }
        public double decryptedMessage { get; set; }
        public double d { get; set; }
        public double p { get; set; }
        public double q { get; set; }
        public double phi { get; set; }
        public double n { get; set; }
        public double e { get; set; }
        public double[] encrptmsg { get; set; }
        public string[] decrptmsg { get; set; }
        
       

    }
}
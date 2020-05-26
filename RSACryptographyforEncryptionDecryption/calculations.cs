using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSACryptographyforEncryptionDecryption
{
    public class calculations:keys
    {
        encryptionanddecryption en = new encryptionanddecryption();

        public void primeNumbers()
        {
            this.p = 11;
            this.q = 3;
        }

        public double calculatingN()
        {
            this.n = this.p * this.q;
            return n;
        }

        public void totient()
        {
            this.phi = (this.p - 1) * (this.q - 1);
        }


        public void Key(double pblicky, string msg)
        {
            this.e = pblicky;
            this.message = msg;
        }

        public void calculateD()
        {
            for (int i = 1; i > 0; i++)
            {
                this.d = i * this.e;
                if ((this.d % this.phi) == 1)
                {
                    this.d = i;
                    break;
                }
            }
        }
        public double checkingGCD()
        {
            while (this.e < this.phi && this.e > 1)
            {
                if ((en.gcd(e, phi)) == 1)
                {
                    return e;
                    break;
                }
                else
                    e++;
            }
            return 1;
        }

        public double[] encrpt()
        {
            this.encrptmsg = en.encrypter(this.message, this.messageToBeEncrypted, this.e, this.encryptedMessage, this.n);
            return encrptmsg;
        }

        public string[] dcrptn(double[] encrptedtext)
        {
            this.decrptmsg = en.decrypter(encrptedtext, this.d, this.messageToBeDecryted, this.decryptedMessage,this.n);
            return decrptmsg;
        }

        
    }
}

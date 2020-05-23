# DM 103348: RSA Cryptography
### PROJECT MEMBERS
StudentID | Name
------------ | -------------
**62324** | **Uzair Hasan**
62112 | Syed Huzaifa Bin Saeed
61030 | Syed Wali Uddin
62846 | Jawad Ahmed
61428 | Daniyal Shafique


## Project Description ##
RSA(Rivest-Shamir-Adleman) is an algorithm used in modern time to send an encrypted messaged by a sender through a medium and decrypt it by the receiver only. The encryption and decryption of a message, this concept was introduced in early ages to secure the message or shouldn’t be read by other than the receiver. So, a concept of encryption and decryption is introduced. Before RSA there were several algorithms to encrypt and decrypt a message all these algorithms were lie into two categories only symmetric cryptography and Asymmetric cryptography. A symmetric cryptography is consist of a one key only and which is only known to two people the sender and receiver so a one can cipher it and the other can decipher it. Then there is an asymmetric cryptography it possess two keys a public key and a private key. The public key is used to encrypt a message or you can say cipher the message and the other key(private) is used to decrypt or decipher a message. The more about algorithm is discussed in [RSA](https://github.com/uzairhasanshah45/DM_PROJECT/blob/master/RSA.md) is here.
## RSA
The RSA algorithm is based mainly on the two things private key and the prime numbers. The keys were discussed above in detail and it tells the importance of the keys, the prime numbers in the RSA is more important than the keys as the prime numbers are used to create a public and private keys. So we have to choose the prime numbers very large as the larger the prime numbers are harder to break the key. In the RSA algorithm the generation of key depends upon the prime number and we have to choose the large prime numbers. There will be 2 large prime numbers. Following are the steps followed in the RSA algorithm.
-	Choose two different large random **prime numbers p and q**
-	Calculate **n=p*q**
- **n** is the modulus for the public key and the private keys
-	Calculate the totient: **ϕ(n)=(p-1)(q-1)
-	Choose an integer  e such that 1 <  e <  ϕ(n), and  e is co-prime to ϕ(n) i.e.: e and  ϕ(n) share no factors other than 1; gcd(e, ϕ(n)) = 1
-	e is released as the public key exponent
- Compute d to satisfy the congruence relation **d.e≡1  mod(ϕ(n) )
- d is kept as the private key exponent
The **public key** is made of the modulus **n** and the public (or encryption) exponent **e**.
The **private key** is made of **p,q** and the private (or decryption) exponent **d** which must be kept secret.

## Discrete Math Concepts Used ##
The whole algorithm in the RSA cryptography is the concept of DM. The encrypting and decrypting of a cipher texts. The method which is most highlighted is the **euclidian** method

### Euclidean Algorithm ###
In mathematics the Euclid's Algorithm is an efficient method for computing GCD(Greatest Common Divisor)

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


public double gcd(double a, double h)
        {
            double temp;
            while (true)
            {
                temp = a % h;

                if (temp == 0)
                {
                    return h;
                }
                a = h;
                h = temp;
            }
        }



## Problems Faced ##
In the project we faced so many issues and problems, but we need to solve them and they were kind of complicated to code it.

### Problem 1: Key Generating ###
The first problem faced in the code is the key generating part where first we need to assume a large prime number as if we initialize the p and q with biginteger data type instead of int then it produce randomly the big numbers which was very hard to handle by this code. To solve this problem we used the prime numbers hard coded as it is a sample algorithm and can easily be handled by the Visual Studio.

### Problem 2: Message Encryption ###
The second problem caused by the first problem the encryption problem. When we face the key generation problem by initializing prime number thats when encryption problem occured when the bigintegers data type the encryption of small messages was very difficult as it is very big numbers and difficult to handled so when we encrypt a small message with only 4-5 letters it produce so big encryption key which is against the RSA Algorithm standard so we make the message according to the key size.


## References ##
- [RSA](https://simple.wikipedia.org/wiki/RSA_algorithm)
- [Euclidean](https://en.wikipedia.org/wiki/Euclidean_algorithm)
- [Lectures](http://discretemathatkiet.22web.org/lectures/22_Cryptography.pdf)
- [Google](https://www.google.com/)
- [Github](https://github.com/)
- [YouTube](https://www.youtube.com/results?search_query=rsa+cryptography+algorithm+)

# DM Project Report
# RSA Cryptography

## Group Members:

- Syed Huzaifa Saeed (62112)
- Uzair Hasan (62324)
- Syed Wali Uddin (61030)
- Jawad Ahmed (62846)
- Daniyal Shafique (61428)

## Submitted To:
**Sir Farooq Zaidi**

# Introduction
RSA(Rivest-Shamir-Adleman) is an algorithm used in modern time to send an encrypted messaged by a sender through a medium and decrypt it by the receiver only. The encryption and decryption of a message, this concept was introduced in early ages to secure the message or shouldn’t be read by other than the receiver. So, a concept of encryption and decryption is introduced. Before RSA there were several algorithms to encrypt and decrypt a message all these algorithms were lie into two categories only symmetric cryptography and Asymmetric cryptography. A symmetric cryptography is consist of a one key only and which is only known to two people the sender and receiver so a one can cipher it and the other can decipher it. Then there is an asymmetric cryptography it possess two keys a public key and a private key. The public key is used to encrypt a message or you can say cipher the message and the other key(private) is used to decrypt or decipher a message.

# Public and Private Key Concept
The public key is shared openly and can be known to anyone because this key is used to encrypt the message only as it is not useful for the third party or an intruder to decrypt the message or help to find the private key. So, the public key is shared to both parties so that they can encrypt a message. Then there comes the private key it is one of the most important key as the integrity and security of a message depends upon it and the private key cant be shared openly as it is the core part of the algorithm and it can only be possessed by the receiver only. In cryptography there is a basic rule that a public key and private key can neither be same nor be 11. This rule is because if the both keys are the same then it can easily be decipher it by the third party and the whole concept of sending a message with full integrity will be fail; and the 11 number is also a problem as it weakens the public and private key to that extinct that if it is used the message can be decrypted more easily than those whose keys aren’t 11.

# RSA
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

# Encrypting a Message:
Alice gives her public key(n and e) to Bob and kept the private key to herself. Bob wants to send a message M to Alice. Bobs encrypts the message M by using:C=m^e  mod n
Bob encrypts the message and sends it to Alice
# Decrypting a Message: 
As Alice has the private key(d) so she can convert the C into M by using: M=c^d mod n
Alice reads the message which Bob sent it by using RSA.
# Working Example:
For an example we choose a small prime number just to be solved easily for an example:
-	Choose two prime numbers
-	P=61 and q=53; compute n=pq
-	N=61*53= 3233
-	Compute the totient ϕ(n)=(p-1)(q-1)
-	ϕ(n)=(61-1)(53-1)=3120
-	Chose e>1 co-prime to 3120
-	E=17
-	Chose d to satisfy d.e modϕ(n)≡1
-	D=2753
-	17*2753=46801=1+15*3120

**To encrypt m=123**

c=〖123〗^17 mod3233=855

**To decrypt c=855**

m=〖855〗^2753 mod 3233=123

# Advantages of RSA Algorithm
The primary advantage of public-key cryptography is increased security and convenience: private keys never need to be transmitted or revealed to anyone.  In a secret-key system, by contrast, the secret keys must be transmitted (either manually or through a communication channel) since the same key is used for encryption and decryption.  A serious concern is that there may be a chance that an enemy can discover the secret key during transmission. Another major advantage of public-key systems is they can provide digital signatures that cannot be repudiated.

# Disadvantages of RSA Algorithm
A disadvantage of using public-key cryptography for encryption is speed, as this subtype of cryptography is usually slow to encrypt a message. There are many secret-key encryption methods that are significantly faster than any currently available public-key encryption method. Another drawback of RSA is that we need a third party to verify the reliablity of the public key.The known method to break the RSA is the meet in the middle process which can possible to break an RSA algorithm.


# Conclusion
The RSA algorithm can be useful after all these drawbacks because of their method to produce both the keys. But, now a days the RSA is used with different cryptographic ciphers to increase the message integrity. To increase the speed in whole encryption of message they found out that they used both asymmetric and symmetric cryptography as both are important and if they should be used wisely than the encryption of a message can be faster and the integrity will be intact.

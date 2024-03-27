Experiment 1 -

Experiment 2 - ROT2 & Ceaser Cipher

ROT2: Its key is simple: each letter of the alphabet is replaced by the next 2 letters, i.e. A is 
replaced by C, B is replaced by D, C is replaced by E etc. “ROT2” literally means “rotating 2 letters 
of the alphabet forward.”
(Set shift value to 2 for In ROT2 Cipher.)
A -> C
B -> D
C -> E
D -> F
E -> G…

Exp:
Orijinal : "HELLO"
ROT2 : " JGNNQ " (When the shift amount is taken as 2)
Ceaser Cipher: The Caesar Cipher, named because it was used by Julius Caesar himself, is 
actually 26 different ciphers, one for each letter of the alphabet. ROT1 is just one of these ciphers. 
A person only needs to be told which Ceasar cipher was used in order to decipher a message. 
For this experiment take 1 to rotate 1 letter forward through the alphabet.
(If the user does not enter an integer value into the texbox, the default value is 1 for in 
Caesar Cipher.)
A -> B
B -> C
C -> D
D -> E
E -> F…

Exp:
Orijinal : "HELLO"
Ceaser: "IFMMP" (When the shift amount is taken as 1)
Task
You will be take a string from user via TextBox like Password. User will be select ROT2 or Ceaser 
Cipher option via radio buttons. When Ceaser Cipher is selected, user must be enter ceaser cipher 
code as integer via a new TextBox which was hidden before selection. The cipher method 
signature and algorithm is given as coded at the end of the document but fill necessary blocks of 
code to get calculated values from method. When encrypt button is clicked, Encipher method is 
called and if password is encrypted, success parameter of method will be true, label parameter of 
method will be visualize “success“ as text message, encryptedMessage parameter will be generated as
encrypted message. If success paramater value true, successLabel’s back ground color will be green.





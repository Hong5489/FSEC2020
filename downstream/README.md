# Downstream (Crypto)
[d.zip](d.zip)

In the zip file got two files which is `downstream.py` and `ctf.html.enc`

Basically it uses the python script to encrypt `ctf.html` become `ctf.html.enc`

It uses **RC4 encryption** to encrypt the HTML file

The main logic explaination:
```py
# Generate password MD5 hash
hashsum = hashlib.md5(password.encode()).hexdigest()
# Split the HTML file into 256 character block
for chunk in split(inlog, 256):
	# Encrypt the block
    encrypted = rc4crypt(chunk, hashsum.encode())
    # Append the encrypted block to the file
    outlog.write(encrypted)
```

We know that RC4 basically is just **XORing the key with plaintext**

According to the source code, it uses the same key :`hashsum` every time 

So we can do some calculation to recover the plaintext:
```
Assume p is plaintext and c is ciphertext
p1 ^ key = c1
p2 ^ key = c2

p1 ^ p2 = c1 ^ c2
```
So if we know one of the plaintext, then we can recover the rest of the plaintext

Luckily it is **HTML file!** Therefore it is easy to guess the plaintext

Lets crack it with a python script!

I guess the first 6 character should be `<html>`
```py
# Read the ciphertext file
text = open("ctf.html.enc").read()
# Simple XOR function
def xor(a,b):
	t = ''
	for i in zip(a,b):
		t += chr(ord(i[0]) ^ ord(i[1]))
	return t
c1 = text[:6]
c2 = text[256:256+6]
# p1 ^ p2 = c1 ^ c2
# In order to recover p2 we need to guess p1
# Guess the first 6 character should be <html>
print xor(xor(c1,c2),'<html>')
```
Result:
```
<h1>Ca
```
Yes! We get the first 6 character of second block!

After some guessing, we get recover many text in second block:
```py
p1 = '<html><head><title>Capture The Flag (CTF)</title>'
c1 = text[:len(p1)]
c2 = text[256:256+len(p1)]
print xor(xor(c1,c2),p1)
```
Result:
```
<h1>Capture The Flag</h1><img src="https://kongwe
```
Now, we need to find which block contains the flag

We can recover all block at once:
```py
p1 = '<html><head><title>Capture The Flag (CTF)</title>'
c1 = text[:len(p1)]

for i in range(0,13):
	cipher = text[256*i:(256*i)+len(p1)]
	print xor(xor(cipher,c1),p1)
```
Result:
```
<html><head><title>Capture The Flag (CTF)</title>
<h1>Capture The Flag</h1><img src="https://kongwe
re usually designed to serve as an educational ex
ngineering, network sniffing, protocol analysis, 
ardware challenges and Jeopardy!.</p><p>In an att
uccess in attacking the other team's machines. De
Two of the more prominent attack/defense CTF's ar
 unknown piece of hardware and having to figure o
variety of questions of different point values an
ing time to approach challenges and prioritizes q
e having their own machine (or small network) to 
core is usually determined by a score reporting s
nclick="promptFlag()">GIVE ME THE FLAG!</button><
```
You can see the last block should contain the flag

Now we can try guess the third block because its easier to guess

```py
p1 = 're usually designed to serve as an educational exercise '
c1 = text[(256*2):(256*2)+len(p1)]

for i in range(0,13):
	cipher = text[256*i:(256*i)+len(p1)]
	print xor(xor(cipher,c1),p1)
```
Result:
```
<html><head><title>Capture The Flag (CTF)</title><style>
<h1>Capture The Flag</h1><img src="https://kongwenbin.co
re usually designed to serve as an educational exercise 
ngineering, network sniffing, protocol analysis, system 
ardware challenges and Jeopardy!.</p><p>In an attack/def
uccess in attacking the other team's machines. Depending
Two of the more prominent attack/defense CTF's are held 
 unknown piece of hardware and having to figure out how 
variety of questions of different point values and diffi
ing time to approach challenges and prioritizes quantity
e having their own machine (or small network) to defend,
core is usually determined by a score reporting service 
nclick="promptFlag()">GIVE ME THE FLAG!</button><script>
```
Yes! We recovered more plaintext!

Now try guess fifth block:
```py
p1 = 'ardware challenges and Jeopardy!.</p><p>In an attack/defense'
c1 = text[(256*4):(256*4)+len(p1)]

for i in range(0,13):
	cipher = text[256*i:(256*i)+len(p1)]
	print xor(xor(cipher,c1),p1)
```
Result:
```
<html><head><title>Capture The Flag (CTF)</title><style>body
<h1>Capture The Flag</h1><img src="https://kongwenbin.com/wp
re usually designed to serve as an educational exercise to g
ngineering, network sniffing, protocol analysis, system admi
ardware challenges and Jeopardy!.</p><p>In an attack/defense
uccess in attacking the other team's machines. Depending on 
Two of the more prominent attack/defense CTF's are held ever
 unknown piece of hardware and having to figure out how to b
variety of questions of different point values and difficult
ing time to approach challenges and prioritizes quantity of 
e having their own machine (or small network) to defend, the
core is usually determined by a score reporting service on t
nclick="promptFlag()">GIVE ME THE FLAG!</button><script>func
```
By guessing over and over again, we managed to get the flag!!!
```
...
...
...
nclick="promptFlag()">GIVE ME THE FLAG!</button><script>function promptFlag(){alert('congratz!! the flag is fskn0WnPl41Nt3xTcyberx');}</script></bo
```
*We didn't solve it in Finals, but it's a fun challenge!*

[Solve script](solve.py)

## Flag 
```
fskn0WnPl41Nt3xTcyberx
```
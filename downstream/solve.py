text = open("ctf.html.enc").read()
def xor(a,b):
	t = ''
	for i in zip(a,b):
		t += chr(ord(i[0]) ^ ord(i[1]))
	return t

p1 = 'variety of questions of different point values and difficulties. Teams attempt to earn the most points in the competition\'s time frame (for example'
c1 = text[(256*8):(256*8)+len(p1)]

for i in range(0,13):
	cipher = text[256*i:(256*i)+len(p1)]
	print xor(xor(cipher,c1),p1)
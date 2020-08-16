import sys
import hashlib
from os.path import dirname, basename, abspath

def split(seq, n):
    while seq:
        yield seq[:n]
        seq = seq[n:]

def rc4crypt(data, key):
    x = 0
    box = list(range(256))
    for i in range(256):
        x = (x + box[i] + key[i % len(key)]) % 256
        box[i], box[x] = box[x], box[i]
    x = 0
    y = 0
    out = []
    for char in data:
        x = (x + 1) % 256
        y = (y + box[x]) % 256
        box[x], box[y] = box[y], box[x]
        out.append(bytes([char ^ box[(box[x] + box[y]) % 256]]))
    return b"".join(out)

inlog = open(sys.argv[1], "rb").read()
outpath = "{0}/{1}.enc".format(dirname(abspath(sys.argv[1])), basename(sys.argv[1]))
outlog = open(outpath, "wb")
password = sys.argv[2]
hashsum = hashlib.md5(password.encode()).hexdigest()

for chunk in split(inlog, 256):
    encrypted = rc4crypt(chunk, hashsum.encode())
    outlog.write(encrypted)

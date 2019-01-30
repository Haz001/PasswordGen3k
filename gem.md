# Password Genorator 3072 (gem)
To install type: gem install passgen3k<br/>
Name of class: Passgen3k
## Fucntions
### test
tests class
### quick
Creates a quick password of 8 characters of any visible characters excluding spaces.
### gen(n)
Creates a password of 'n' length of any visible characters excluding spaces.<br/>
n - number of characters
### gen_c(n,a,b,c,d)
Creates a password of 'n' length of any characters allowed by a, b, c and d.<br/>
n - number of characters, int<br/>
a - allow cappital letters, boolean<br/>
b - allow numbers, boolean<br/>
c - allow special characters letters, boolean<br/>
d - allow lower case letters, boolean
#### Warning
**If you have all as false it will infinitly loop**

import random
import time
os_i = True
try:
    import os
except:
    os_i = False

class vr:  
    pwd = ""
    run = True
    lc_lst = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']
    smbl_lst = ['!','"','£','$','%','^','&','*','(',')','\\','|',',','<','.','>','[',']','{','}','_','-','+','=',':',';','@',"'",'#','~']
    lstper = 0
class fn:
    def main():
        while vr.run:
            if os_i:
                os.system("cls")
            print("=====< Password Genorator 3072 >=====\nWelcome to Password Gen 3072 (Python ver)\nTo create a password choose an option:\n0 - BasicPassword\n1 - Custome varibles\n9 - Exit")
            cmd = input(">")
            if cmd == '0':
                print("How many letters (10 < recomended < 100)")
                try:
                    v0t = int(input(">"))
                except:
                    print("input error")
                vr.pwd = fn.passgen1(v0t)
                fn.present(vr.pwd)                
                input("Press enter to go back to main menu\n>")
            elif cmd == '1':
                print("How many letters (10 < recomended < 100)")
                v0t = int(input(">"))
                v1t = bool(int(input("Include capital letters\n(1 - true, 0 - false)\n>")))
                #print(v1t)
                v2t = bool(int(input("Include numbers letters\n(1 - true, 0 - false)\n>")))
                #print(v2t)
                v3t = bool(int(input("Include symbols letters\n(1 - true, 0 - false)\n>")))
                #print(v3t)
                vr.pwd = fn.passgen1(v0t,v1t,v2t,v3t)
                fn.present(vr.pwd)
                input("Press enter to go back to main menu\n>")
            elif cmd == '9':
                vr.run=False
            else:
                print("error number not recognized")
    def loading():
        if os_i:os.system("cls")
        for i in range(0,11):
            fn.pb(i/10)
            time.sleep(0.05)
        fn.main()
    def pb(pf):
        if(vr.lstper != (round(pf*200)/2)):
            vr.lstper = (round(pf*200)/2)
            lnw = 100
            i = int(round(pf*lnw))
            if os_i:os.system("cls")
            print("["+"="*i+"-"*(lnw-i)+"]\n"+str(round(pf*200)/2)+"%")
    
    def passgen1(v0t = 10,v1t = True,v2t = True,v3t = True):
        pwd=str()
        count=1
        while count <= v0t:
            r_i = random.randint(0,3)
            if r_i == 0:
                pwd+=random.choice(vr.lc_lst)
            elif r_i == 1 and v1t:
                pwd+=random.choice(vr.lc_lst).upper()
            elif r_i == 2 and v2t:
                pwd+=str(random.randint(0,9))
            elif r_i == 3 and v3t:
                pwd+=random.choice(vr.smbl_lst)
            else:
                pwd+=random.choice(vr.lc_lst)
            fn.pb(count/v0t)
            count+=1
        return pwd
    def present(pwd):
        pid = 0
##        try:
##            ##print(str(5)+5)
##            pid_r = open("data",'r')
##            pid = int(pid_r.read())
##            pid_r.close()
##            pid_w = open("data",'w')
##            pid_w.write(str(pid+1))
##            pid_w.close()
##            pw_a = open("pw.txt",'a+')
##            pw_a.write("\n-----< Pass "+str(pid)+" >-----\nPassword:\n"+pwd+"\n-----< Pass end >-----")
##            pw_a.close()
##            print("A copy of your password was saved to pw.txt under id: "+str(pid))
##        except:
##            pid_w = open("data",'w+')
##            pid_w.write(str(pid+1))
##            pid_w.close()
##            print("-----< ! >-----\nsaving error!!!\n")
        print("Your new password is :\n"+pwd+"\n")
        

fn.loading()

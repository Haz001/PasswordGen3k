import random#gets a modual with random number and random picker
os_i = True#sets a varible thats used to detect if os has been imported
try:#try argument start
    import os#tryes to import os for cls command
except:#if try fails argument
    os_i = False#sets os_i to false to stop the program trying to use os if no os modual
pwd = ""#pasword string
run = True#varible to see if it should run again
lc_lst = ['a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z']#list of characters
smbl_lst = ['!','"','£','$','%','^','&','*','(',')','\\','|',',','<','.','>','[',']','{','}','_','-','+','=',':',';','@',"'",'#','~']#list of symbols
while run:#runs a loop while run is true
    if os_i:#checks if os modul is imported
        os.system("cls")#clears screens
    print("Welcome to Password Gen 3000\nTo create a password choose an option:\n0 - BasicPassword\n1 - Exit")#prints menu
    try:#try argument started
        cmd = int(input(">"))#gets user input and stores it in cmd
        if cmd == 0:#if user entered 0
            print("How many letters (10 recomended)")#prints menu
            try:#try argument
                cmd = int(input(">"))#gets input again
                pwd=str()#clears old password
                count=1#resets count
                while count <= cmd:#
                    r_i = random.randint(0,3)
                    if r_i == 0:
                        pwd+=random.choice(lc_lst)
                    elif r_i == 1:
                        pwd+=random.choice(lc_lst).upper()
                    elif r_i == 2:
                        pwd+=str(random.randint(0,9))
                    else:
                        pwd+=random.choice(smbl_lst)
                    count+=1;
                print("Your new password is:\n"+pwd)                
                input("Press enter to go back to main menu")
            except:#catches error
                print("error")#prints error
        elif cmd == 1:#user entered 1
            run=False#breaks loop and ends program
        else:#catches errors
            print("error")#catches errors
    except:
        print("error")

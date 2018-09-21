/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package passgenorator3072;
import java.util.Scanner;
import java.util.Random;
/**
 *
 * @author 17001038
 */
public class PassGenorator3072 {

    public static String pass = "";
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        System.out.println("=====< Password Genorator 3072 >=====\nWelcome to Password Gen 3072 (java ver)\nTo create a password choose an option:\n1 - BasicPassword\n0 - Exit");
        
        
        Short cmd1 = input_s();
        Random rand = new Random();
        
        
        if (cmd1 == 1){
           System.out.println("How many letters (10 < recomended < 100)");
           long cmd2 = input_l();
           for (long i = 0;i<=cmd2;i++){
               
               pass += (char) (rand.nextInt(125-33)+33);
           }
           System.out.println("Pass;\n"+pass);
           
        }else if (cmd1 == 0){
            System.exit(0);
        }
        
    }
    
    /// -----< Fuctions to collect inputs with ease >-----
    public static short input_s(){
        Scanner s = new Scanner(System.in);
        short x = 0;
        try{
            x = s.nextShort();
        }catch(java.util.InputMismatchException e){
            System.out.println("Error: with input.");
            s.next();
        }
        return x;
    }
    public static long input_l(){
        Scanner s = new Scanner(System.in);
        long x = 0;
        try{
            x = s.nextLong();
        }catch(java.util.InputMismatchException e){
            System.out.println("Error: with input.");
            s.next();
        }
        return x;
    }
    
    
}

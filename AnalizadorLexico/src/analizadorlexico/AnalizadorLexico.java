/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package analizadorlexico;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class AnalizadorLexico {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       String patron = ("(while)|([a-zA-Z]+)|([>|<|=]+)|([0-9]+)|([(|)]+)|([{|}]+)|(:)");
       String texto = "while (x=0) < (y=0)";
       
       Pattern p = Pattern.compile(patron);
       Matcher m = p.matcher(texto);
       
       while (m.find()){
           String token = m.group(1);
           if(token != null){
               System.out.println("palabra reservada: " + token);
           }
           String token2 = m.group(2);
           if(token2 != null){
               System.out.println("variables: " + token2);
           }
           String token3 = m.group(3);
           if(token3 != null){
               System.out.println("Operadores: " + token3);
           }
           String token4 = m.group(4);
           if(token4 != null){
               System.out.println("Números: " + token4);
           }
           String token5 = m.group(5);
           if(token5 != null){
               System.out.println("Paréntesis: " + token5);
           }
           String token6 = m.group(6);
           if(token6 != null){
               System.out.println("Llaves: " + token6);
           }
           String token7 = m.group(7);
           if(token7 != null){
               System.out.println("Dos puntos: " + token7);
           }
       }
    }
    
}

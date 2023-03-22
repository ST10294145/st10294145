
package com.mycompany.helloworld2;
import javax.swing.JOptionPane;

public class Helloworld2 {
    public String getGreeting() {
        return"Hello World";
   
    }

    public static void main(String[] args) {
        System.out.println(new Helloworld2().getGreeting());
        JOptionPane.showMessageDialog(null, "Hello");
        
    }
}

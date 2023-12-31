package Ejemplos_de_ventanas;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class VentanaPrincipal extends JFrame {

    public VentanaPrincipal() {
        setTitle("Ventana Principal");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(300, 200);

        JButton btn1 = new JButton("Ir a Ventana Secundaria 1");
        btn1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                VentanaSecundaria1 ventanaSecundaria1 = new VentanaSecundaria1();
                ventanaSecundaria1.setVisible(true);
                setVisible(false);
            }
        });

        JButton btn2 = new JButton("Ir a Ventana Secundaria 2");
        btn2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                VentanaSecundaria2 ventanaSecundaria2 = new VentanaSecundaria2();
                ventanaSecundaria2.setVisible(true);
                setVisible(false);
            }
        });

        JPanel panel = new JPanel();
        panel.setLayout(new GridLayout(2, 1));
        panel.add(btn1);
        panel.add(btn2);

        add(panel);
    }
}
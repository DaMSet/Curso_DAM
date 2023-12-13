package Ejemplos_de_ventanas;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

class VentanaSecundaria1 extends JFrame {

    public VentanaSecundaria1() {
        setTitle("Ventana Secundaria 1");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(300, 200);

        JButton btn = new JButton("Ir a Ventana Principal");
        btn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                ventanaPrincipal.setVisible(true);
                setVisible(false);
            }
        });

        JPanel panel = new JPanel();
        panel.add(btn);

        add(panel);
    }
}
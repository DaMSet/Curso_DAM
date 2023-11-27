package Vista;


import javax.swing.GroupLayout;
import javax.swing.LayoutStyle;

import Controller.ControllerCRUD;
import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Luis
 */
public class PanelCRUD extends javax.swing.JPanel {

    private ControllerCRUD controller;
    
       public PanelCRUD() {
        initComponents();
        this.inicializarPanel();
        ControllerCRUD.cargarTabla(tablaVehiculos);
        add(jScrollPane1);
        add(jLabel1);
        add(jLabel2);
        add(jLabelMatricula);
        add(txtModelo);
        add(txtMarca);
        add(txtMatricula);
        add(btRegistrar);
        add(btBorrar);
        
    }

 
private void txtModeloActionPerformed(java.awt.event.ActionEvent evt) {										
 
	 // TODO add your handling code here:
 
}										
 
 
 
private void btRegistrarActionPerformed(java.awt.event.ActionEvent evt) {										
 
	

  //  DAOVehiculoImpl.getInstance().insertarVehiculo(new Vehiculo(txtMatricula.getText(), ))

    ControllerCRUD.insertarVehiculo(this, tablaVehiculos);

 
 
 
}	

private void btBorrarActionPerformed(java.awt.event.ActionEvent evt) {										
	 
	

	  //  DAOVehiculoImpl.getInstance().insertarVehiculo(new Vehiculo(txtMatricula.getText(), ))

	    ControllerCRUD.borrarVehiculos(this, tablaVehiculos);

	 
	 
	 
	}	


 
 
 
public javax.swing.JTextField getTxtMatricula() {
	return txtMatricula;
}



public void setTxtMatricula(javax.swing.JTextField txtMatricula) {
	this.txtMatricula = txtMatricula;
}



public javax.swing.JTextField getTxtMarca() {
	return txtMarca;
}



public void setTxtMarca(javax.swing.JTextField txtMarca) {
	this.txtMarca = txtMarca;
}



public javax.swing.JTextField getTxtModelo() {
	return txtModelo;
}



public void setTxtModelo(javax.swing.JTextField txtModelo) {
	this.txtModelo = txtModelo;
}
 
private javax.swing.JButton btRegistrar;
private javax.swing.JButton btBorrar;
 
private javax.swing.JLabel jLabel1;
 
private javax.swing.JLabel jLabel2;
 
private javax.swing.JLabel jLabelMatricula;
 
private javax.swing.JScrollPane jScrollPane1;
 
private javax.swing.JTable tablaVehiculos;
 
private javax.swing.JTextField txtMatricula;
 
private javax.swing.JTextField txtMarca;
 
private javax.swing.JTextField txtModelo;
    /**
     * Creates new form PanelCRUD
     */
 
    
    
    
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    // End of variables declaration//GEN-END:variables


private void inicializarPanel() {
 
 
 
	 jLabel1 = new javax.swing.JLabel();
	 jLabel1.setBounds(10, 14, 29, 14);
 
	 jScrollPane1 = new javax.swing.JScrollPane();
	 jScrollPane1.setBounds(10, 122, 375, 181);
 
	 tablaVehiculos = new javax.swing.JTable();
 
	 txtMarca = new javax.swing.JTextField();
	 txtMarca.setBounds(63, 11, 196, 20);
 
	 txtModelo = new javax.swing.JTextField();
	 txtModelo.setBounds(63, 40, 210, 25);
 
	 jLabel2 = new javax.swing.JLabel();
	 jLabel2.setBounds(10, 45, 34, 14);
 
	 jLabelMatricula = new javax.swing.JLabel();
	 jLabelMatricula.setBounds(10, 79, 43, 14);
 
	 txtMatricula = new javax.swing.JTextField();
	 txtMatricula.setBounds(63, 76, 196, 20);
 
	 btRegistrar = new javax.swing.JButton();
	 btRegistrar.setBounds(336, 11, 77, 23);
	 
	 btBorrar = new javax.swing.JButton();
	 btBorrar.addActionListener(new ActionListener() {
	 	public void actionPerformed(java.awt.event.ActionEvent e) {
	 		btBorrarActionPerformed(e);
	 	}
	 });
	 btBorrar.setText("Borrar");
	 btBorrar.setBounds(336, 62, 77, 23);
 
 
 
	 
 
 
 
	 jLabel1.setText("Marca");
 
 
 
	 tablaVehiculos.setModel(new javax.swing.table.DefaultTableModel(
 
		 new Object [][] {
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null},
 
			 {null, null, null, null}
 
		 },
 
		 new String [] {
 
			 "Title 1", "Title 2", "Title 3", "Title 4"
 
		 }
 
	 ));
 
	 jScrollPane1.setViewportView(tablaVehiculos);
 
 
 
	 txtMarca.setName("marca"); // NOI18N
 
 
 
	 txtModelo.setToolTipText("");
 
	 txtModelo.setName("modelo"); // NOI18N
 
	 txtModelo.addActionListener(new java.awt.event.ActionListener() {
 
		 public void actionPerformed(java.awt.event.ActionEvent evt) {
 
			 txtModeloActionPerformed(evt);
 
		 }
 
	 });
 
 
 
	 jLabel2.setText("Modelo");
 
 
 
	 jLabelMatricula.setText("Matricula");
 
 
 
	 txtMatricula.setToolTipText("");
 
 
 
	 btRegistrar.setText("Registrar");
 
	 btRegistrar.setActionCommand("btRegistrar");
 
	 btRegistrar.setName("btRegistrar"); // NOI18N
 
	 btRegistrar.addActionListener(new java.awt.event.ActionListener() {
 
		 public void actionPerformed(java.awt.event.ActionEvent evt) {
 
			 btRegistrarActionPerformed(evt);
 
		 }
 
	 });
	 setLayout(null);
 
 
 
	 javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
	 layout.setHorizontalGroup(
	 	layout.createParallelGroup(Alignment.LEADING)
	 		.addGroup(layout.createSequentialGroup()
	 			.addContainerGap()
	 			.addGroup(layout.createParallelGroup(Alignment.LEADING)
	 				.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 375, GroupLayout.PREFERRED_SIZE)
	 				.addGroup(layout.createSequentialGroup()
	 					.addGroup(layout.createParallelGroup(Alignment.LEADING)
	 						.addComponent(jLabel1)
	 						.addComponent(jLabel2)
	 						.addComponent(jLabelMatricula))
	 					.addPreferredGap(ComponentPlacement.UNRELATED)
	 					.addGroup(layout.createParallelGroup(Alignment.LEADING)
	 						.addComponent(txtModelo, 210, 210, 210)
	 						.addGroup(layout.createParallelGroup(Alignment.LEADING, false)
	 							.addComponent(txtMarca)
	 							.addComponent(txtMatricula, GroupLayout.DEFAULT_SIZE, 196, Short.MAX_VALUE)))
	 					.addPreferredGap(ComponentPlacement.RELATED, 73, Short.MAX_VALUE)
	 					.addComponent(btRegistrar)))
	 			.addGap(27))
	 );
	 layout.setVerticalGroup(
	 	layout.createParallelGroup(Alignment.LEADING)
	 		.addGroup(layout.createSequentialGroup()
	 			.addContainerGap()
	 			.addGroup(layout.createParallelGroup(Alignment.LEADING)
	 				.addGroup(layout.createParallelGroup(Alignment.BASELINE)
	 					.addComponent(jLabel1)
	 					.addComponent(txtMarca, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
	 				.addComponent(btRegistrar))
	 			.addPreferredGap(ComponentPlacement.RELATED)
	 			.addGroup(layout.createParallelGroup(Alignment.BASELINE)
	 				.addComponent(jLabel2)
	 				.addComponent(txtModelo, GroupLayout.PREFERRED_SIZE, 25, GroupLayout.PREFERRED_SIZE))
	 			.addPreferredGap(ComponentPlacement.UNRELATED)
	 			.addGroup(layout.createParallelGroup(Alignment.BASELINE)
	 				.addComponent(jLabelMatricula)
	 				.addComponent(txtMatricula, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
	 			.addGap(26)
	 			.addComponent(jScrollPane1, GroupLayout.PREFERRED_SIZE, 181, GroupLayout.PREFERRED_SIZE)
	 			.addContainerGap(GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
	 );
 
	 this.setLayout(layout);
 
 
 
	 
 
}// </editor-fold>	
}

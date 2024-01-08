package Servidor;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;

import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor_Chivato {

	//Deberia realizar todo el proceso dentro de un hilo, para poder recibir varios clientes 
	
	
	public static void main(String[] args)  {
		// TODO Auto-generated method stub
		String puerto = "4000";

		ServerSocket soket;
		try {
			soket = new ServerSocket();
			
			System.out.println("Servidor iniciado");
			
			while (true) 
			{
			
								
				Socket	Cliente = soket.accept();
					
					//Entrada de datos
					InputStream is = Cliente.getInputStream();
					
					DataInputStream dis = new DataInputStream(is);
					
					
					//Salida de datos
					OutputStream os = Cliente.getOutputStream();
					
					DataOutputStream dos = new DataOutputStream(os);
					
					
					
					System.out.println(dis.readUTF());
					
					dos.writeUTF("Me ha llegado el mensaje");
									
				
				Cliente.close();
			}
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		
		
	}

}

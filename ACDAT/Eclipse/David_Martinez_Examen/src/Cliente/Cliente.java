package Cliente;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Cliente {

	private static String Direccion = "192.168.56.1";
	static int puerto = 4000;
	
	public static void main(String[] args) throws IOException {
	//Socket socketCliente = new Socket(Direccion,puerto);
	
	
	String mensaje = "Hola desde cliente 1";
	
	System.out.println(Cliente.hablarConElserver(mensaje));
	
	
	}
	
	
	public static String hablarConElserver(String mensaje1) throws UnknownHostException, IOException {
		
		Socket socketCliente =  new Socket(Direccion, puerto);
		
		String mensaje = mensaje1;
			
		//Entrada de datos
		InputStream is = socketCliente.getInputStream();
		
		DataInputStream dis = new DataInputStream(is);
		
		
		//Salida de datos
		OutputStream os = socketCliente.getOutputStream();
		
		DataOutputStream dos = new DataOutputStream(os);
		
		
		dos.writeUTF(mensaje);
		
		String mensajeVuelta =  dis.readUTF();
		
		
		return mensajeVuelta;
		}
	
	
}

package server;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) throws IOException {
		/*
		int numeroPuerto = 6000;
		
		Socket clienteConectado = null;
		
		//Entrada de datos de cliente al servidor
		InputStream entrada=null;
		
		try {
			
			ServerSocket servidor = new ServerSocket(numeroPuerto);
			
			clienteConectado = servidor.accept();
			
			entrada = clienteConectado.getInputStream();
				
			
			
		} catch (IOException e) {
		
			e.printStackTrace();
		}
		DatalnputStream flujoEntrada = new DatalnputStream(entrada);
		*/
		
		int numeroPuerto = 6000;// Puerto
		
		ServerSocket servidor = new ServerSocket(numeroPuerto);
		
		Socket clienteConectado = null;
		
		
		System.out.println("Esperando al cliente....");
		clienteConectado = servidor.accept();
		
		// CREO FLUJO DE ENTRADA DEL CLIENTE
		InputStream entrada = null;
		entrada = clienteConectado.getInputStream();
		DataInputStream flujoEntrada = new DataInputStream(entrada);
		
		
		//EL CLIENTE ME ENVIA UN MENSAJE
		System.out.println("Recibiendo del CLIENTE: \n\t" +

		flujoEntrada.readUTF());
		// CREO FLUJO DE SALIDA AL CLIENTE
		OutputStream salida = null;
		salida = clienteConectado.getOutputStream();
		DataOutputStream flujoSalida = new DataOutputStream(salida);
		
		
		// ENVIO UN SALUDO AL CLIENTE
		flujoSalida.writeUTF("Saludos al cliente del servidor");
		
		
		
		// CERRAR STREAMS Y SOCKETS
		
		entrada.close();
		flujoEntrada.close();
		salida.close ();
		flujoSalida.close ();
		clienteConectado.close();
		servidor.close();

	}

}

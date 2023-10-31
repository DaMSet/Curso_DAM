package Servidor;

import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;

public class Servidor {

	public static void main(String[] args) throws IOException {
		
		
		ServerSocket serverSocket = new ServerSocket(6000);
		
		while(true) 
		{
			Socket cliente;
			cliente = serverSocket.accept();	
			
			HiloServidor hilo = new HiloServidor(cliente);
			hilo.start();
			
		}
		        	
		        	
		        	
		        	

		        	
		   
		
	}

}

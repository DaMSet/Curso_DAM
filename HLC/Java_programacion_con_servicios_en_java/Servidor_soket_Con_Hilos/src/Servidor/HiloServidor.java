package Servidor;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;

public class HiloServidor extends Thread{

	BufferedReader fentrada;
	PrintWriter fsalida;
	Socket socket = null;
	
	
	public HiloServidor(Socket s) throws IOException 
	{
		
		socket = s;
		//Se crean los flujos de entrada
		
		fsalida = new PrintWriter(socket.getOutputStream(),true);
		fentrada = new BufferedReader(new InputStreamReader(socket.getInputStream()));
		
		
	}
	
	
	public void run()
	{
		
		
		
	}
	
	
	
	
}

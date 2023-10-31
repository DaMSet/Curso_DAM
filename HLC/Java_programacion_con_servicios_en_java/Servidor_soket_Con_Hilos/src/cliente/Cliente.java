package cliente;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;


public class Cliente {
public static void main(String[] args) throws IOException {
		
		
		Socket ClienteSocket = new Socket("localHost",6000);
		
		PrintWriter fsalida = new PrintWriter(ClienteSocket.getOutputStream(),true);
		BufferedReader fentrada = new BufferedReader(new InputStreamReader(ClienteSocket.getInputStream()));
		

		        	
		   
		
	}

}
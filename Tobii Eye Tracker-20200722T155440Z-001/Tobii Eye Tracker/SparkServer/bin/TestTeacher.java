import java.io.BufferedReader;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.*;
import java.util.Random;

public class TestTeacher {
	
	public static void main(String[] args) {
		try {
			InetAddress ip = InetAddress.getByName("127.0.0.1");
			Socket socket = new Socket(ip,61600);
			DataInputStream inputStream = new DataInputStream(socket.getInputStream());
			char temp='#';
			String input="#NewTeacher#"+new Random().nextInt(99999)+";";
			
			//waiting to start
			while(temp!=';') {
				System.out.println("Trying read from server");
				char c=inputStream.readChar();
				temp=c;
				System.out.println(temp);
			}
			
			//giving the server my info
			DataOutputStream outputStream = new DataOutputStream(socket.getOutputStream());
			//for(int i;i<input.length();i++)
				outputStream.writeChars(input);
		while(true) {
			
		}
			
				
		}catch(Exception e) {
			e.printStackTrace();
		}
		
		
		
	}
}
package com.fk.test;

import java.util.Scanner;

@SuppressWarnings("all")
public class SolveAngle {
	
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		  while(true) {
			  System.out.println("������A�����ά���꣺");
			  System.out.print("X_a��");
			  Double X_a=Double.parseDouble(scan.next());
			  System.out.print("Y_a��");
			  Double Y_a=Double.parseDouble(scan.next());
			  System.out.print("Z_a��");
			  Double Z_a=Double.parseDouble(scan.next());
			  Coordinates a=new Coordinates();
			  a.setX(X_a);a.setY(Y_a);a.setZ(Z_a);
			  System.out.println("������B�����ά���꣺");
			  System.out.print("X_b��");
			  Double X_b=Double.parseDouble(scan.next());
			  System.out.print("Y_b��");
			  Double Y_b=Double.parseDouble(scan.next());
			  System.out.print("Z_b��");
			  Double Z_b=Double.parseDouble(scan.next());
			  Coordinates b=new Coordinates();
			  b.setX(X_b);b.setY(Y_b);b.setZ(Z_b);
			  System.out.println("������C�����ά���꣺");
			  System.out.print("X_c��");
			  Double X_c=Double.parseDouble(scan.next());
			  System.out.print("Y_c��");
			  Double Y_c=Double.parseDouble(scan.next());
			  System.out.print("Z_c��");
			  Double Z_c=Double.parseDouble(scan.next());
			  Coordinates c=new Coordinates();
			  c.setX(X_c);c.setY(Y_c);c.setZ(Z_c);
			  System.out.print("A("+a.getX()+","+a.getY()+","+a.getZ()+")  B("+b.getX()+","+b.getY()+","+b.getZ()+")  C("+c.getX()+","+c.getY()+","+c.getZ()+")");
			  GetAngle ang=new GetAngle(a,b,c);
			  System.out.println("��A:"+ang.getAng_A()+"\t��B:"+ang.getAng_B()+"\t��C:"+ang.getAng_C());
			  System.out.println("���롰-1�������������⽨������");
			  if(scan.next()=="-1")
				  break;
		  }
	}

}
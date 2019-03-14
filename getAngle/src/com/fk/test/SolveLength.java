package com.fk.test;

import java.util.Scanner;

@SuppressWarnings("all")
public class SolveLength {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		System.out.println("--请输入标准模型的三维坐标(C左，A右，B上)--");
		  System.out.println("A点的三维坐标：");
		  System.out.print("X_a：");
		  Double X_a=Double.parseDouble(scan.next());
		  System.out.print("Y_a：");
		  Double Y_a=Double.parseDouble(scan.next());
		  System.out.print("Z_a：");
		  Double Z_a=Double.parseDouble(scan.next());
		  Coordinates a=new Coordinates();
		  a.setX(X_a);a.setY(Y_a);a.setZ(Z_a);
		  System.out.println("B点的三维坐标：");
		  System.out.print("X_b：");
		  Double X_b=Double.parseDouble(scan.next());
		  System.out.print("Y_b：");
		  Double Y_b=Double.parseDouble(scan.next());
		  System.out.print("Z_b：");
		  Double Z_b=Double.parseDouble(scan.next());
		  Coordinates b=new Coordinates();
		  b.setX(X_b);b.setY(Y_b);b.setZ(Z_b);
		  System.out.println("C点的三维坐标：");
		  System.out.print("X_c：");
		  Double X_c=Double.parseDouble(scan.next());
		  System.out.print("Y_c：");
		  Double Y_c=Double.parseDouble(scan.next());
		  System.out.print("Z_c：");
		  Double Z_c=Double.parseDouble(scan.next());
		  Coordinates c=new Coordinates();
		  c.setX(X_c);c.setY(Y_c);c.setZ(Z_c);
		  System.out.print("A("+a.getX()+","+a.getY()+","+a.getZ()+")  B("+b.getX()+","+b.getY()+","+b.getZ()+")  C("+c.getX()+","+c.getY()+","+c.getZ()+")");
		  GetAngle ang=new GetAngle(a,b,c);
		  System.out.println("角A:"+ang.getAng_A()+"\t角B:"+ang.getAng_B()+"\t角C:"+ang.getAng_C());
		  System.out.println("请输入允许B高中偏移量的最大值：");
		  Double p_x=Double.parseDouble(scan.next());
		  b.setY(b.getY()-p_x);
		  System.out.println("\nB的高度减少"+p_x+"后，三角形的数据如下：");
		  System.out.print("A("+a.getX()+","+a.getY()+","+a.getZ()+")  B("+b.getX()+","+b.getY()+","+b.getZ()+")  C("+c.getX()+","+c.getY()+","+c.getZ()+")");
		  GetAngle ang1=new GetAngle(a,b,c);
		  System.out.println("角A:"+ang1.getAng_A()+"\t角B:"+ang1.getAng_B()+"\t角C:"+ang1.getAng_C());
		  System.out.println("\nB的高度增加"+p_x+"后，三角形的数据如下：");
		  b.setY(b.getY()+p_x+p_x);
		  System.out.print("A("+a.getX()+","+a.getY()+","+a.getZ()+")  B("+b.getX()+","+b.getY()+","+b.getZ()+")  C("+c.getX()+","+c.getY()+","+c.getZ()+")");
		  GetAngle ang2=new GetAngle(a,b,c);
		  System.out.println("角A:"+ang2.getAng_A()+"\t角B:"+ang2.getAng_B()+"\t角C:"+ang2.getAng_C());
		  System.err.println("\n在B点允许的最大偏移量"+p_x+"下，AB的波动范围是（"+ang1.getL_c()+","+ang2.getL_c()+") 模型的AB="+ang.getL_c());
		  

	}

}

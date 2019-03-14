package com.fk.test;

public class GetAngle {
	private Double ang_A;//角A
	private Double ang_B;//角B
	private Double ang_C;//角C
	private Double l_a;
	private Double l_b;
	private Double l_c;
	
	
	public Double getL_a() {
		return l_a;
	}
	public void setL_a(Double l_a) {
		this.l_a = l_a;
	}
	public Double getL_b() {
		return l_b;
	}
	public void setL_b(Double l_b) {
		this.l_b = l_b;
	}
	public Double getL_c() {
		return l_c;
	}
	public void setL_c(Double l_c) {
		this.l_c = l_c;
	}
	public Double getAng_A() {
		return ang_A;
	}
	public void setAng_A(Double ang_A) {
		this.ang_A = ang_A;
	}
	public Double getAng_B() {
		return ang_B;
	}
	public void setAng_B(Double ang_B) {
		this.ang_B = ang_B;
	}
	public Double getAng_C() {
		return ang_C;
	}
	public void setAng_C(Double ang_C) {
		this.ang_C = ang_C;
	}
	public GetAngle(Coordinates a,Coordinates b,Coordinates c) {
		this.l_a=length(b,c);//a
		this.l_c=length(a,b);//c
		this.l_b=length(a,c);//b
		System.out.println("\na="+l_a+" b="+l_b+" c="+l_c);
		this.ang_A=getAng(l_b,l_c,l_a)*180/Math.PI;
		this.ang_B=getAng(l_a,l_c,l_b)*180/Math.PI;
		this.ang_C=getAng(l_a,l_b,l_c)*180/Math.PI;
	}
	public Double length(Coordinates x,Coordinates y) {
		Double a=x.getX()-y.getX();
		Double b=x.getY()-y.getY();
		Double c=x.getZ()-y.getZ();
		return Math.sqrt(Math.pow(a, 2.0)+Math.pow(b, 2.0)+Math.pow(c, 2.0));
	}
	//求c对应的叫C
	public Double getAng(Double a,Double b,Double c) {
		return Math.acos((a*a+b*b-c*c)/(2.0*a*b));
	}

}

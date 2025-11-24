#ifndef MATRIX_H
#define MATRIX_H

#include "Vector3.h"
#include "Quaternion.h"

#define Matrix4x4 csaijo
#define Vector4 iuopysadh7
struct Matrix4x4 {

	 float m00;
         float m10;
         float m20;
         float m30;
         float m01;
         float m11;
         float m21;
         float m31;
         float m02;
         float m12;
         float m22;
         float m32;
         float m03;
         float m13;
         float m23;
	 float m33;
	 
Matrix4x4(){}

    

};

 Matrix4x4 operator*(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            Matrix4x4 res;
            res.m00 = lhs.m00 * rhs.m00 + lhs.m01 * rhs.m10 + lhs.m02 * rhs.m20 + lhs.m03 * rhs.m30;
            res.m01 = lhs.m00 * rhs.m01 + lhs.m01 * rhs.m11 + lhs.m02 * rhs.m21 + lhs.m03 * rhs.m31;
            res.m02 = lhs.m00 * rhs.m02 + lhs.m01 * rhs.m12 + lhs.m02 * rhs.m22 + lhs.m03 * rhs.m32;
            res.m03 = lhs.m00 * rhs.m03 + lhs.m01 * rhs.m13 + lhs.m02 * rhs.m23 + lhs.m03 * rhs.m33;

            res.m10 = lhs.m10 * rhs.m00 + lhs.m11 * rhs.m10 + lhs.m12 * rhs.m20 + lhs.m13 * rhs.m30;
            res.m11 = lhs.m10 * rhs.m01 + lhs.m11 * rhs.m11 + lhs.m12 * rhs.m21 + lhs.m13 * rhs.m31;
            res.m12 = lhs.m10 * rhs.m02 + lhs.m11 * rhs.m12 + lhs.m12 * rhs.m22 + lhs.m13 * rhs.m32;
            res.m13 = lhs.m10 * rhs.m03 + lhs.m11 * rhs.m13 + lhs.m12 * rhs.m23 + lhs.m13 * rhs.m33;

            res.m20 = lhs.m20 * rhs.m00 + lhs.m21 * rhs.m10 + lhs.m22 * rhs.m20 + lhs.m23 * rhs.m30;
            res.m21 = lhs.m20 * rhs.m01 + lhs.m21 * rhs.m11 + lhs.m22 * rhs.m21 + lhs.m23 * rhs.m31;
            res.m22 = lhs.m20 * rhs.m02 + lhs.m21 * rhs.m12 + lhs.m22 * rhs.m22 + lhs.m23 * rhs.m32;
            res.m23 = lhs.m20 * rhs.m03 + lhs.m21 * rhs.m13 + lhs.m22 * rhs.m23 + lhs.m23 * rhs.m33;

            res.m30 = lhs.m30 * rhs.m00 + lhs.m31 * rhs.m10 + lhs.m32 * rhs.m20 + lhs.m33 * rhs.m30;
            res.m31 = lhs.m30 * rhs.m01 + lhs.m31 * rhs.m11 + lhs.m32 * rhs.m21 + lhs.m33 * rhs.m31;
            res.m32 = lhs.m30 * rhs.m02 + lhs.m31 * rhs.m12 + lhs.m32 * rhs.m22 + lhs.m33 * rhs.m32;
            res.m33 = lhs.m30 * rhs.m03 + lhs.m31 * rhs.m13 + lhs.m32 * rhs.m23 + lhs.m33 * rhs.m33;

            return res;
        }

/*Vector3 MultiplyPoint(Vector3 &point, Matrix4x4 &matrice) {
     Vector3 res;
     float w;
     res.x = matrice.m00 * point.x + matrice.m01 * point.y + matrice.m02* point.z + matrice.m03;
     res.y = matrice.m10 * point.x + m11 * point.y + m12 * point.z + m13;
     res.z = matice.m20 * point.x + matrice.m21 * point.y + matrice.m22 * point.z + matrice.23;
     w = matrice.m30 * point.x + matrice.m31 * point.y + matrice.m32 * point.z + matrice.m33;
   
     w = 1.f / w;
     res.x *= w;
     res.y *= w;
     res.z *= w;
     return res;
       
      }*/
struct Vector4{
  float x;
  float y;
  float z;
  float w;

  Vector4();
  Vector4(float x, float y, float z, float w);
  ~Vector4();
};

Vector4::Vector4() {}
Vector4::Vector4(float x, float y, float z, float w) : x(x), y(y), z(z), w(w) {}
Vector4::~Vector4() {}

   Vector4 operator*(Matrix4x4 lhs, Vector4 vector)
        {
            Vector4 res;
            res.x = lhs.m00 * vector.x + lhs.m01 * vector.y + lhs.m02 * vector.z + lhs.m03 * vector.w;
            res.y = lhs.m10 * vector.x + lhs.m11 * vector.y + lhs.m12 * vector.z + lhs.m13 * vector.w;
            res.z = lhs.m20 * vector.x + lhs.m21 * vector.y + lhs.m22 * vector.z + lhs.m23 * vector.w;
            res.w = lhs.m30 * vector.x + lhs.m31 * vector.y + lhs.m32 * vector.z + lhs.m33 * vector.w;
            return res;
        }
        
  float NormalizeAngle (float angle){
	while (angle>360)
		angle -= 360;
	while (angle<0)
		angle += 360;
	return angle;
}

struct Vector2{
 float x;
 float y;
 };
Vector3 NormalizeAngles (Vector3 angles){
	angles.x = NormalizeAngle (angles.x);
	angles.y = NormalizeAngle (angles.y);
	angles.z = NormalizeAngle (angles.z);
	return angles;
}

Vector3 ToEulerRad(Quaternion q1){

	float sqw = q1.w * q1.w;
	float sqx = q1.x * q1.x;
	float sqy = q1.y * q1.y;
	float sqz = q1.z * q1.z;
	float unit = sqx + sqy + sqz + sqw;
	float test = q1.x * q1.w - q1.y * q1.z;
	Vector3 v;

	if (test>0.4995f*unit) {
		v.y = 2.0f * atan2f (q1.y, q1.x);
		v.x = M_PI / 2.0f;
		v.z = 0;
		return NormalizeAngles(v * Rad2Deg);
	}
	if (test<-0.4995f*unit) {
		v.y = -2.0f * atan2f (q1.y, q1.x);
		v.x = -M_PI / 2.0f;
		v.z = 0;
		return NormalizeAngles (v * Rad2Deg);
	}
	Quaternion q(q1.w, q1.z, q1.x, q1.y);
	v.y = atan2f (2.0f * q.x * q.w + 2.0f * q.y * q.z, 1 - 2.0f * (q.z * q.z + q.w * q.w)); // yaw
	v.x = asinf (2.0f * (q.x * q.z - q.w * q.y)); // pitch
	v.z = atan2f (2.0f * q.x * q.y + 2.0f * q.z * q.w, 1 - 2.0f * (q.y * q.y + q.z * q.z)); // roll
	return NormalizeAngles (v * Rad2Deg);
}

Quaternion GetRotationToLocation(Vector3 targetLocation, float y_bias, Vector3 localPosition){
	return Quaternion::LookRotation((targetLocation + Vector3(0, y_bias, 0)) - localPosition, Vector3(0, 1, 0));
}

#endif //MATRIX_H

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PhysicsEngineForFun
{
    public class AeroForceControlOnRigidBody : AeroForceOnRigidBody
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal AeroForceControlOnRigidBody(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PhysicsEngineForFunPINVOKE.AeroForceControlOnRigidBody_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AeroForceControlOnRigidBody obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~AeroForceControlOnRigidBody()
        {
            Dispose();
        }

        public override void Dispose()
        {
            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        PhysicsEngineForFunPINVOKE.delete_AeroForceControlOnRigidBody(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public AeroForceControlOnRigidBody(Matrix3 arg0, Matrix3 min, Matrix3 max, Vector3 position, Vector3 windspeed) : this(PhysicsEngineForFunPINVOKE.new_AeroForceControlOnRigidBody(Matrix3.getCPtr(arg0), Matrix3.getCPtr(min), Matrix3.getCPtr(max), Vector3.getCPtr(position), Vector3.getCPtr(windspeed)), true)
        {
            if (PhysicsEngineForFunPINVOKE.SWIGPendingException.Pending) throw PhysicsEngineForFunPINVOKE.SWIGPendingException.Retrieve();
        }

        public override void UpdateForce(RigidBody body, float duration)
        {
            PhysicsEngineForFunPINVOKE.AeroForceControlOnRigidBody_UpdateForce(swigCPtr, RigidBody.getCPtr(body), duration);
        }

        public float controlSetting
        {
            set
            {
                PhysicsEngineForFunPINVOKE.AeroForceControlOnRigidBody_controlSetting_set(swigCPtr, value);
            }
            get
            {
                float ret = PhysicsEngineForFunPINVOKE.AeroForceControlOnRigidBody_controlSetting_get(swigCPtr);
                return ret;
            }
        }

    }
}
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
    public class ParticleLink : IParticleContactGenerator
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal ParticleLink(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PhysicsEngineForFunPINVOKE.ParticleLink_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ParticleLink obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~ParticleLink()
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
                        PhysicsEngineForFunPINVOKE.delete_ParticleLink(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }

        public float GetCurrentLength()
        {
            float ret = PhysicsEngineForFunPINVOKE.ParticleLink_GetCurrentLength(swigCPtr);
            return ret;
        }

        public override bool AddContact(ParticleContact contact)
        {
            bool ret = PhysicsEngineForFunPINVOKE.ParticleLink_AddContact(swigCPtr, ParticleContact.getCPtr(contact));
            return ret;
        }

        public Particle particle0
        {
            set
            {
                PhysicsEngineForFunPINVOKE.ParticleLink_particle0_set(swigCPtr, Particle.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = PhysicsEngineForFunPINVOKE.ParticleLink_particle0_get(swigCPtr);
                Particle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Particle(cPtr, false);
                return ret;
            }
        }

        public Particle particle1
        {
            set
            {
                PhysicsEngineForFunPINVOKE.ParticleLink_particle1_set(swigCPtr, Particle.getCPtr(value));
            }
            get
            {
                global::System.IntPtr cPtr = PhysicsEngineForFunPINVOKE.ParticleLink_particle1_get(swigCPtr);
                Particle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Particle(cPtr, false);
                return ret;
            }
        }

        public ParticleLink() : this(PhysicsEngineForFunPINVOKE.new_ParticleLink(), true)
        {
        }

    }
}
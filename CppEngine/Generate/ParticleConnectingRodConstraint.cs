//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class ParticleConnectingRodConstraint : ParticleConstraint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal ParticleConnectingRodConstraint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PhysicsEngineForFunPINVOKE.ParticleConnectingRodConstraint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ParticleConnectingRodConstraint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ParticleConnectingRodConstraint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PhysicsEngineForFunPINVOKE.delete_ParticleConnectingRodConstraint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override bool AddContact(ParticleContact contact) {
    bool ret = PhysicsEngineForFunPINVOKE.ParticleConnectingRodConstraint_AddContact(swigCPtr, ParticleContact.getCPtr(contact));
    return ret;
  }

  public float Length {
    set {
      PhysicsEngineForFunPINVOKE.ParticleConnectingRodConstraint_Length_set(swigCPtr, value);
    } 
    get {
      float ret = PhysicsEngineForFunPINVOKE.ParticleConnectingRodConstraint_Length_get(swigCPtr);
      return ret;
    } 
  }

  public ParticleConnectingRodConstraint() : this(PhysicsEngineForFunPINVOKE.new_ParticleConnectingRodConstraint(), true) {
  }

}

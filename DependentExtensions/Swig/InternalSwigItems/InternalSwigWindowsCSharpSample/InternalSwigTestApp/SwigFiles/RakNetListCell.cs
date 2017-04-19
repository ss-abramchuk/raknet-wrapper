/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RakNetListCell : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetListCell(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RakNetListCell obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetListCell() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetListCell(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

    public Cell this[int index]  
    {  
        get   
        {
            return Get((uint)index); // use indexto retrieve and return another value.    
        }  
        set   
        {
            Replace(value, value, (uint)index, "Not used", 0);// use index and value to set the value somewhere.   
        }  
    } 

  public RakNetListCell() : this(RakNetPINVOKE.new_RakNetListCell__SWIG_0(), true) {
  }

  public RakNetListCell(RakNetListCell original_copy) : this(RakNetPINVOKE.new_RakNetListCell__SWIG_1(RakNetListCell.getCPtr(original_copy)), true) {
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetListCell CopyData(RakNetListCell original_copy) {
    RakNetListCell ret = new RakNetListCell(RakNetPINVOKE.RakNetListCell_CopyData(swigCPtr, RakNetListCell.getCPtr(original_copy)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Cell Get(uint position) {
    Cell ret = new Cell(RakNetPINVOKE.RakNetListCell_Get(swigCPtr, position), false);
    return ret;
  }

  public void Push(Cell input, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Push(swigCPtr, Cell.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public Cell Pop() {
    Cell ret = new Cell(RakNetPINVOKE.RakNetListCell_Pop(swigCPtr), false);
    return ret;
  }

  public void Insert(Cell input, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Insert__SWIG_0(swigCPtr, Cell.getCPtr(input), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(Cell input, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Insert__SWIG_1(swigCPtr, Cell.getCPtr(input), file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(Cell input, Cell filler, uint position, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Replace__SWIG_0(swigCPtr, Cell.getCPtr(input), Cell.getCPtr(filler), position, file, line);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Replace(Cell input) {
    RakNetPINVOKE.RakNetListCell_Replace__SWIG_1(swigCPtr, Cell.getCPtr(input));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAtIndex(uint position) {
    RakNetPINVOKE.RakNetListCell_RemoveAtIndex(swigCPtr, position);
  }

  public void RemoveAtIndexFast(uint position) {
    RakNetPINVOKE.RakNetListCell_RemoveAtIndexFast(swigCPtr, position);
  }

  public void RemoveFromEnd(uint num) {
    RakNetPINVOKE.RakNetListCell_RemoveFromEnd__SWIG_0(swigCPtr, num);
  }

  public void RemoveFromEnd() {
    RakNetPINVOKE.RakNetListCell_RemoveFromEnd__SWIG_1(swigCPtr);
  }

  public uint Size() {
    uint ret = RakNetPINVOKE.RakNetListCell_Size(swigCPtr);
    return ret;
  }

  public void Clear(bool doNotDeallocateSmallBlocks, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Clear(swigCPtr, doNotDeallocateSmallBlocks, file, line);
  }

  public void Preallocate(uint countNeeded, string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Preallocate(swigCPtr, countNeeded, file, line);
  }

  public void Compress(string file, uint line) {
    RakNetPINVOKE.RakNetListCell_Compress(swigCPtr, file, line);
  }

}

}

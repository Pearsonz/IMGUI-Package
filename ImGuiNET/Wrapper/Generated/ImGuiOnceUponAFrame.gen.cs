using System;
using Unity.Collections.LowLevel.Unsafe;
using System.Text;
using UnityEngine;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiOnceUponAFrame
    {
        public int RefFrame;
    }
    public unsafe partial struct ImGuiOnceUponAFramePtr
    {
        public ImGuiOnceUponAFrame* NativePtr { get; }
        public ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => NativePtr = nativePtr;
        public ImGuiOnceUponAFramePtr(IntPtr nativePtr) => NativePtr = (ImGuiOnceUponAFrame*)nativePtr;
        public static implicit operator ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => new ImGuiOnceUponAFramePtr(nativePtr);
        public static implicit operator ImGuiOnceUponAFrame* (ImGuiOnceUponAFramePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiOnceUponAFramePtr(IntPtr nativePtr) => new ImGuiOnceUponAFramePtr(nativePtr);
        public ref int RefFrame => ref UnsafeUtility.AsRef<int>(&NativePtr->RefFrame);
        public void Destroy()
        {
            ImGuiNative.ImGuiOnceUponAFrame_destroy(NativePtr);
        }
    }
}

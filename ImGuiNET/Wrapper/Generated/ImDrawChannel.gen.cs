using System;
using Unity.Collections.LowLevel.Unsafe;
using System.Text;
using UnityEngine;

namespace ImGuiNET
{
    public unsafe partial struct ImDrawChannel
    {
        public ImVector _CmdBuffer;
        public ImVector _IdxBuffer;
    }
    public unsafe partial struct ImDrawChannelPtr
    {
        public ImDrawChannel* NativePtr { get; }
        public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
        public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
        public static implicit operator ImDrawChannelPtr(ImDrawChannel* nativePtr) => new ImDrawChannelPtr(nativePtr);
        public static implicit operator ImDrawChannel* (ImDrawChannelPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImDrawChannelPtr(IntPtr nativePtr) => new ImDrawChannelPtr(nativePtr);
        public ImPtrVector<ImDrawCmdPtr> _CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->_CmdBuffer, UnsafeUtility.SizeOf<ImDrawCmd>());
        public ImVector<ushort> _IdxBuffer => new ImVector<ushort>(NativePtr->_IdxBuffer);
    }
}

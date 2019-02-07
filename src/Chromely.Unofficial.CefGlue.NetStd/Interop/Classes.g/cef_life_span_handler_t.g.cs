﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_life_span_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal IntPtr _on_before_popup;
        internal IntPtr _on_after_created;
        internal IntPtr _do_close;
        internal IntPtr _on_before_close;
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void add_ref_delegate(cef_life_span_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int release_delegate(cef_life_span_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_one_ref_delegate(cef_life_span_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int has_at_least_one_ref_delegate(cef_life_span_handler_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int on_before_popup_delegate(cef_life_span_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_string_t* target_url, cef_string_t* target_frame_name, CefWindowOpenDisposition target_disposition, int user_gesture, cef_popup_features_t* popupFeatures, cef_window_info_t* windowInfo, cef_client_t** client, cef_browser_settings_t* settings, int* no_javascript_access);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_after_created_delegate(cef_life_span_handler_t* self, cef_browser_t* browser);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate int do_close_delegate(cef_life_span_handler_t* self, cef_browser_t* browser);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        internal delegate void on_before_close_delegate(cef_life_span_handler_t* self, cef_browser_t* browser);
        
        private static int _sizeof;
        
        static cef_life_span_handler_t()
        {
            _sizeof = Marshal.SizeOf(typeof(cef_life_span_handler_t));
        }
        
        internal static cef_life_span_handler_t* Alloc()
        {
            var ptr = (cef_life_span_handler_t*)Marshal.AllocHGlobal(_sizeof);
            *ptr = new cef_life_span_handler_t();
            ptr->_base._size = (UIntPtr)_sizeof;
            return ptr;
        }
        
        internal static void Free(cef_life_span_handler_t* ptr)
        {
            Marshal.FreeHGlobal((IntPtr)ptr);
        }
        
    }
}

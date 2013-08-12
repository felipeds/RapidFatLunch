using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

// mimimi já tem esse using na classe do server e deveria ter 1 só no sistema mas n sei onde por agora e vai ficar com 2 mesmo
using anyID = System.UInt16;
using uint64 = System.UInt64;

namespace LeagueOfLegendsAutoChat
{
    class TSClient
    {
#if x64
			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_initClientLib")]
			public static extern uint ts3client_initClientLib(ref client_callback_struct arg0, ref client_callbackrare_struct arg1, LogTypes arg2, string arg3, string arg4);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_getClientLibVersion")]
			public static extern uint ts3client_getClientLibVersion(out IntPtr arg0);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_freeMemory")]
			public static extern uint ts3client_freeMemory(IntPtr arg0);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_spawnNewServerConnectionHandler")]
			public static extern uint ts3client_spawnNewServerConnectionHandler(int port, out uint64 arg0);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_openCaptureDevice")]
            public static extern uint ts3client_openCaptureDevice(uint64 arg0, string arg1, string arg2);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_openPlaybackDevice")]
            public static extern uint ts3client_openPlaybackDevice(uint64 arg0, string arg1, string arg2);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_createIdentity")]
			public static extern uint ts3client_createIdentity(out IntPtr arg0);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_startConnection", CharSet = CharSet.Ansi)]
            public static extern uint ts3client_startConnection(uint64 arg0, string identity, string ip, uint port, string nick, ref string defaultchannelarray, string defaultchannelpassword, string serverpassword);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_stopConnection")]
            public static extern uint ts3client_stopConnection(uint64 arg0, string arg1);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_destroyServerConnectionHandler")]
            public static extern uint ts3client_destroyServerConnectionHandler(uint64 arg0);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_destroyClientLib")]
			public static extern uint ts3client_destroyClientLib();

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_getChannelVariableAsString")]
            public static extern uint ts3client_getChannelVariableAsString(uint64 arg0, uint64 arg1, ChannelProperties arg2, out IntPtr arg3);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_getErrorMessage")]
			public static extern uint ts3client_getErrorMessage(uint arg0, IntPtr arg1);

			[DllImport("ts3client_win64.dll", EntryPoint = "ts3client_getClientVariableAsString")]
            public static extern uint ts3client_getClientVariableAsString(uint64 arg0, anyID arg1, ClientProperties arg2, out IntPtr arg3);
#else
        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_initClientLib")]
        public static extern uint ts3client_initClientLib(ref client_callback_struct arg0, ref client_callbackrare_struct arg1, LogTypes arg2, string arg3, string arg4);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_getClientLibVersion")]
        public static extern uint ts3client_getClientLibVersion(out IntPtr arg0);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_freeMemory")]
        public static extern uint ts3client_freeMemory(IntPtr arg0);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_spawnNewServerConnectionHandler")]
        public static extern uint ts3client_spawnNewServerConnectionHandler(int port, out uint64 arg0);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_openCaptureDevice")]
        public static extern uint ts3client_openCaptureDevice(uint64 arg0, string arg1, string arg2);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_openPlaybackDevice")]
        public static extern uint ts3client_openPlaybackDevice(uint64 arg0, string arg1, string arg2);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_createIdentity")]
        public static extern uint ts3client_createIdentity(out IntPtr arg0);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_startConnection", CharSet = CharSet.Ansi)]
        public static extern uint ts3client_startConnection(uint64 arg0, string identity, string ip, uint port, string nick, ref string defaultchannelarray, string defaultchannelpassword, string serverpassword);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_stopConnection")]
        public static extern uint ts3client_stopConnection(uint64 arg0, string arg1);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_destroyServerConnectionHandler")]
        public static extern uint ts3client_destroyServerConnectionHandler(uint64 arg0);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_destroyClientLib")]
        public static extern uint ts3client_destroyClientLib();

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_getChannelVariableAsString")]
        public static extern uint ts3client_getChannelVariableAsString(uint64 arg0, uint64 arg1, ChannelProperties arg2, out IntPtr arg3);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_getErrorMessage")]
        public static extern uint ts3client_getErrorMessage(uint arg0, IntPtr arg1);

        [DllImport("ts3client_win32.dll", EntryPoint = "ts3client_getClientVariableAsString")]
        public static extern uint ts3client_getClientVariableAsString(uint64 arg0, anyID arg1, ClientProperties arg2, out IntPtr arg3);
#endif
    }
}

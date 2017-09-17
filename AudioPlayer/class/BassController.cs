using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace AudioPlayer
{
    public static class BassController
{
        //ЧАСТОТА ДИСКРЕТИЗАЦИИ
        private static int HZ = 44100;
        //Состояние инициализации
        public static bool initDefaultDevice;

        public static int Stream;

        public static int volume = 100;

        private static bool initBass(int hz)
        {
            if (!initDefaultDevice)
                initDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
            return initDefaultDevice;
        }

        public static void stop()
        {
                Bass.BASS_ChannelStop(Stream);
                Bass.BASS_StreamFree(Stream);
        }

        public static void setStreamVolume(int stream, int vol)
        {
            volume = 100 - vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100F);
        }

        public static void play(String filename, int vol)
        {
            stop();
            if (initBass(HZ))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if(Stream != 0)
                {
                    volume = 100 - vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
        }

        public static int getStreamTime(int stream)
        {
            long timeBytes = Bass.BASS_ChannelGetLength(stream);
            double time = Bass.BASS_ChannelBytes2Seconds(stream, timeBytes);
            return (int)time;
        }

        public static int getPosOfStream(int stream)
        {
            long pos = Bass.BASS_ChannelGetPosition(stream);
            int posSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, pos);
            return posSec;
        }

        public static void setStreamPosition(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }
}
}

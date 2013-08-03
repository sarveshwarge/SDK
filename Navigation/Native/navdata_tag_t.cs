namespace ARDrone2Client.Common.Navigation.Native
{
    public enum navdata_tag_t : ushort
    {
        NAVDATA_DEMO,
        NAVDATA_TIME,
        NAVDATA_RAW_MEASURES,
        NAVDATA_PHYS_MEASURES,
        NAVDATA_GYROS_OFFSETS,
        NAVDATA_EULER_ANGLES,
        NAVDATA_REFERENCES,
        NAVDATA_TRIMS,
        NAVDATA_RC_REFERENCES,
        NAVDATA_PWM,
        NAVDATA_ALTITUDE,
        NAVDATA_VISION_RAW,
        NAVDATA_VISION_OF,
        NAVDATA_VISION,
        NAVDATA_VISION_PERF,
        NAVDATA_TRACKERS_SEND,
        NAVDATA_VISION_DETECT,
        NAVDATA_WATCHDOG,
        NAVDATA_ADC_DATA_FRAME,
        NAVDATA_VIDEO_STREAM,
        NAVDATA_GAMES,
        NAVDATA_PRESSURE_RAW,
        NAVDATA_MAGNETO,
        NAVDATA_WIND,
        NAVDATA_KALMAN_PRESSURE,
        NAVDATA_HDVIDEO_STREAM,
        NAVDATA_WIFI,
        NAVDATA_ZIMMU_3000,
        NAVDATA_NUMS,
        NAVDATA_CKS = 0xffff,
    }
}
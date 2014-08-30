using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class _EXIF : Form
    {
        Semaphore sem;

        public _EXIF(Image eingabeBild, Semaphore sem_in)
        {
            InitializeComponent();


            Bitmap bild = (Bitmap)eingabeBild;

            sem = sem_in;

            PropertyItem[] properties = bild.PropertyItems;
            ASCIIEncoding metaEncoder = new ASCIIEncoding();
            foreach (PropertyItem pr in properties)
            {
                int wert = pr.Id;
                try
                {
                    switch (wert)
                    {
                        case 11:
                            textBox2.AppendText("ProcessingSoftware: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 269:
                            textBox2.AppendText("DocumentName:" + metaEncoder.GetString(pr.Value));
                            break;
                        case 270:
                            textBox2.AppendText("ImageDescription: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 271:
                            textBox2.AppendText("Recording equipment: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 272:
                            textBox2.AppendText("Model: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 305:
                            textBox2.AppendText("Software/ Firmware Version: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 33434:
                            Int16 ExposureTime = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ExposureTime: " + ExposureTime.ToString());
                            break;
                        case 315:
                            textBox2.AppendText("Artist: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 316:
                            textBox2.AppendText("Host Computer Info: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 333:
                            textBox2.AppendText("Each ink used in a separated image: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 337:
                            textBox2.AppendText("Description of the printing environment: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 32781:
                            textBox2.AppendText("ImageID: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 33432:
                            textBox2.AppendText("Copyright information: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 34852:
                            textBox2.AppendText("Spektralempfindlichkeit: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 36867:
                            textBox2.AppendText("Date original image data was generated: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 37394:
                            textBox2.AppendText("Security classification: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 37395:
                            textBox2.AppendText("Record of what has been done to the image: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 50708:
                            textBox2.AppendText("Camera model: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 50735:
                            textBox2.AppendText("Camera Serial No: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 50971:
                            textBox2.AppendText("Preview Date: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 36868:
                            textBox2.AppendText("Date image stored as digital data: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 37520:
                            textBox2.AppendText("record fractions of seconds for the <DateTime> tag: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 37521:
                            textBox2.AppendText("record fractions of seconds for the <DateTimeOriginal> tag: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 37522:
                            textBox2.AppendText("record fractions of seconds for the <DateTimeDigitized> tag: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 40964:
                            textBox2.AppendText("Name of audio file related to the image data: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42016:
                            textBox2.AppendText("ImageUniqueID: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42032:
                            textBox2.AppendText("CameraOwnerName: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42033:
                            textBox2.AppendText("BodySerialNumber: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42035:
                            textBox2.AppendText("Lens manufactor: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42036:
                            textBox2.AppendText("Lens Model: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 42037:
                            textBox2.AppendText("Lens Serial Number: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 4096:
                            textBox2.AppendText("File format: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 8:
                            textBox2.AppendText("GPSSatellites: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 9:
                            textBox2.AppendText("GPSStatus: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 10:
                            textBox2.AppendText("GPSMeasureMode: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 12:
                            textBox2.AppendText("GPSSpeedRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 14:
                            textBox2.AppendText("GPSTrackRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 16:
                            textBox2.AppendText("GPSImgDirectionRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 18:
                            textBox2.AppendText("GPSMapDatum: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 19:
                            textBox2.AppendText("GPSDestLatitudeRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 21:
                            textBox2.AppendText("GPSDestLongitudeRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 23:
                            textBox2.AppendText("GPSDestBearingRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 25:
                            textBox2.AppendText("GPSDestDistanceRef: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 29:
                            textBox2.AppendText("GPSDateStamp: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 256:
                            Int16 abc = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Width: " + abc);
                            break;
                        case 254:
                            Int16 bcd = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("NewSubfileType: " + bcd);
                            break;
                        case 257:
                            Int16 cde = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Height: " + cde);
                            break;
                        case 273:
                            Int16 def = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("StripOffsets: " + def);
                            break;
                        case 512:
                            Int16 efg = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("JPEGProc: " + efg.ToString());
                            break;
                        case 34853:
                            Int16 fgh = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("GPS Tag: " + fgh.ToString());
                            break;
                        case 37393:
                            Int16 ghi = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Image Number: " + ghi.ToString());
                            break;
                        case 50970:
                            Int16 ijk = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("PreviewColorSpace: " + ijk.ToString());
                            break;
                        case 258:
                            Int16 jkl = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Bits per Sample: " + jkl.ToString());
                            break;
                        case 259:
                            Int16 klm = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Compression: " + klm.ToString());
                            break;
                        case 274:
                            Int16 lmn = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Orientation: " + lmn.ToString());
                            break;
                        case 277:
                            Int16 mno = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Samples per Pixel: " + mno.ToString());
                            break;
                        case 530:
                            Int16 nop = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("YCbCrSubSampling: " + nop.ToString());
                            break;
                        case 34850:
                            Int16 opq = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ExposureProgram: " + opq.ToString());
                            break;
                        case 34855:
                            Int16 pqr = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ISOSpeedRatings: " + pqr.ToString());
                            break;
                        case 34858:
                            Int16 qrs = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("TimeZoneOffset: " + qrs.ToString());
                            break;
                        case 34859:
                            Int16 rst = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("SelfTimerMode: " + rst.ToString());
                            break;
                        case 37383:
                            Int16 stu = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("MeteringMode: " + stu.ToString());
                            break;
                        case 37384:
                            Int16 tuv = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("LightSource: " + tuv.ToString());
                            break;
                        case 37385:
                            Int16 uvw = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Flash: " + uvw.ToString());
                            break;
                        case 37399:
                            Int16 vwx = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("SensingMethod: " + vwx.ToString());
                            break;
                        case 40961:
                            Int16 wxy = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ColorSpace: " + wxy.ToString());
                            break;
                        case 41990:
                            Int16 xyz = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("SceneCaptureType: " + xyz.ToString());
                            break;
                        case 282:
                            Int16 xres = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("XResolution: " + xres.ToString());
                            break;
                        case 283:
                            Int16 yres = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("YResolution: " + yres.ToString());
                            break;
                        case 296:
                            Int16 resUnit = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Resolution Unit: " + resUnit.ToString());
                            break;
                        case 531:
                            Int16 YCbCrPositioning = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("YCbCrPositioning: " + YCbCrPositioning.ToString());
                            break;
                        case 33437:
                            Int16 fnumber = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("F-Number: " + fnumber.ToString());
                            break;
                        case 36864:
                            Int16 exifV = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("EXIF-Version: " + exifV.ToString());
                            break;
                        case 37121:
                            Int16 compConf = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ComponentsConfiguration: " + compConf.ToString());
                            break;
                        case 37377:
                            Int16 shutterSpeed = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Shutter Speed: " + shutterSpeed.ToString());
                            break;
                        case 37378:
                            Int16 aperture = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ApertureValue: " + aperture.ToString());
                            break;
                        case 37379:
                            Int16 brightness = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Brightness Value: " + brightness.ToString());
                            break;
                        case 37380:
                            Int16 exposureBias = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("ExposureBiasValue: " + exposureBias.ToString());
                            break;
                        case 37381:
                            Int16 maxAperture = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Max Aperture Value " + maxAperture.ToString());
                            break;
                        case 37386:
                            Int16 focalLength = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Focal Length: " + focalLength.ToString());
                            break;
                        case 37500:
                            Int16 makerNote = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Maker Note: " + makerNote.ToString());
                            break;
                        case 37510:
                            Int16 uCom = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("User Comment: " + uCom.ToString());
                            break;
                        case 40960:
                            Int16 flashpix = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("FlashpixVersion: " + flashpix.ToString());
                            break;
                        case 40962:
                            Int16 pixelX = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("PixelXDimension: " + pixelX.ToString());
                            break;
                        case 40963:
                            Int16 pixelY = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("PixelYDimension: " + pixelY.ToString());
                            break;
                        case 0:
                            Int16 GPSVersionID = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("GPSVersionID: " + GPSVersionID.ToString());
                            break;
                        case 41495:
                            Int16 SensingMethod = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("SensingMethod: " + SensingMethod.ToString());
                            break;
                        case 513:
                            Int16 JPEGInterchangeFormat = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("JPEGInterchangeFormat: " + JPEGInterchangeFormat.ToString());
                            break;
                        case 41729:
                            Int16 sceneType = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("SceneType: " + sceneType.ToString());
                            break;
                        case 41986:
                            Int16 exposuremode = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Exposure Mode: " + exposuremode.ToString());
                            break;
                        case 41987:
                            Int16 WhiteBalance = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("WhiteBalance: " + WhiteBalance.ToString());
                            break;
                        case 41989:
                            Int16 FocalLengthIn35mmFilm = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("FocalLengthIn35mmFilm: " + FocalLengthIn35mmFilm.ToString());
                            break;
                        case 514:
                            Int16 JPEGInterchangeFormatLength = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("JPEGInterchangeFormatLength: " + JPEGInterchangeFormatLength.ToString());
                            break;
                        case 37122:
                            Int16 CompressedBitsPerPixel = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("CompressedBitsPerPixel: " + CompressedBitsPerPixel.ToString());
                            break;
                        case 41728:
                            UInt16 FileSource = BitConverter.ToUInt16(pr.Value, 0);
                            textBox2.AppendText("FileSource: " + FileSource.ToString());
                            break;
                        case 41985:
                            Int16 CustomRendered = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("CustomRendered: " + CustomRendered.ToString());
                            break;
                        case 306:
                            textBox2.AppendText("DateTime: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 7:
                            Int16 GPSTimeStamp = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("GPSTimeStamp: " + GPSTimeStamp.ToString());
                            break;
                        case 2:
                            uint degreesNumeratorLat = BitConverter.ToUInt32(pr.Value, 0);
                            uint degreesDenominatorLat = BitConverter.ToUInt32(pr.Value, 4);
                            double degreesLat = (double)degreesNumeratorLat / (double)degreesDenominatorLat;

                            uint minutesNumeratorLat = BitConverter.ToUInt32(pr.Value, 8);
                            uint minutesDenominatorLat = BitConverter.ToUInt32(pr.Value, 12);
                            double minutesLat = (double)minutesNumeratorLat / (double)minutesDenominatorLat;

                            uint secondsNumeratorLat = BitConverter.ToUInt32(pr.Value, 16);
                            uint secondsDenominatorLat = BitConverter.ToUInt32(pr.Value, 20);
                            double secondsLat = (double)secondsNumeratorLat / (double)secondsDenominatorLat;

                            double coorditateLat = degreesLat + (minutesLat / 60d) + (secondsLat / 3600d);
                            string gpsRefLat;
                            foreach (PropertyItem prop in properties)
                            {
                                if (prop.Id == 1)
                                {
                                    gpsRefLat = metaEncoder.GetString(prop.Value);
                                    char a = gpsRefLat[0];
                                    if (a == 'S' || a == 'W')
                                        coorditateLat = coorditateLat * -1;
                                    string latid = coorditateLat.ToString();
                                    latid = latid.Replace(',', '.');
                                    textBox2.AppendText("Latitude: " + latid);
                                    break;
                                }
                            }
                            break;
                        case 4:
                            uint degreesNumerator = BitConverter.ToUInt32(pr.Value, 0);
                            uint degreesDenominator = BitConverter.ToUInt32(pr.Value, 4);
                            double degrees = (double)degreesNumerator / (double)degreesDenominator;

                            uint minutesNumerator = BitConverter.ToUInt32(pr.Value, 8);
                            uint minutesDenominator = BitConverter.ToUInt32(pr.Value, 12);
                            double minutes = (double)minutesNumerator / (double)minutesDenominator;

                            uint secondsNumerator = BitConverter.ToUInt32(pr.Value, 16);
                            uint secondsDenominator = BitConverter.ToUInt32(pr.Value, 20);
                            double seconds = (double)secondsNumerator / (double)secondsDenominator;

                            double coorditate = degrees + (minutes / 60d) + (seconds / 3600d);
                            string gpsRef;
                            foreach (PropertyItem prop in properties)
                            {
                                if (prop.Id == 3)
                                {
                                    gpsRef = metaEncoder.GetString(prop.Value);
                                    char b = gpsRef[0];
                                    if (b == 'S' || b == 'W')
                                        coorditate = coorditate * -1;
                                    string longi = coorditate.ToString();
                                    longi = longi.Replace(',', '.');
                                    textBox2.AppendText("Longitude: " + longi);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            textBox2.AppendText("Latitude Ref: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 3:
                            textBox2.AppendText("Longitude Ref: " + metaEncoder.GetString(pr.Value));
                            break;
                        case 6:
                            Int16 altitude = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Altitude: " + altitude.ToString());
                            break;
                        case 5:
                            Int16 atitudeRef = BitConverter.ToInt16(pr.Value, 0);
                            textBox2.AppendText("Altitude Ref: " + atitudeRef.ToString());
                            break;
                        default:
                            continue;
                    }
                    textBox2.AppendText("\n");
                }
                catch
                {

                }
            }
            sem.Release();
        }
    }
}
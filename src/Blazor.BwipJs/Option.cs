using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.BwipJs
{
    public class Option
    {
        public string Text { get; set; }
        public string BarcodeType { get; set; }
        public int ScaleX { get; set; }
        public int? ScaleY { get; set; }
        public int Height { get; set; }
        public int? Width { get; set; }
        public bool IncludeText { get; set; } = true;
        public string TextXAlign { get; set; }
        public string TextYAlign { get; set; }
        public string Rotate { get; set; }

        public Option(string text, BarcodeType barcodeType, int scaleX, int? scaleY, int height, int? width, bool includeText, TextXAlign textXAlign, TextYAlign textYAlign, Rotate rotate)
        {
            Text = text;
            BarcodeType = barcodeType.ToString().Replace('_', '-');
            ScaleX = scaleX;
            ScaleY = scaleY;
            Height = height;
            Width = width;
            IncludeText = includeText;
            TextXAlign = textXAlign.ToString();
            TextYAlign = textYAlign.ToString();
            Rotate = rotate.ToString();
        }
    }

    public enum Rotate
    {
        [Description("Normal")] N,
        [Description("Clockwise(right) 90 degree rotate")] R,
        [Description("Counter-clockwise (left) 90 degree rotate")] L,
        [Description("Inverted 180 degree rotate")] I
    }

    public enum TextXAlign
    {
        center, offleft, left, right, offright, justify
    }

    public enum TextYAlign
    {
        below, center, above
    }

    public enum BarcodeType
    {
        [Description("AusPost 4 State Customer Code")] auspost,
        [Description("Aztec Code")] azteccode,
        [Description("Aztec Runes")] aztecrune,
        [Description("BC412")] bc412,
        [Description("COOP 2 of 5")] coop2of5,
        [Description("Channel Code")] channelcode,
        [Description("Codabar")] rationalizedCodabar,
        [Description("Codablock F")] codablockf,
        [Description("Code 11")] code11,
        [Description("Code 128")] code128,
        [Description("Code 16K")] code16k,
        [Description("Code 25")] code2of5,
        [Description("Code 39")] code39,
        [Description("Code 39 Extended")] code39ext,
        [Description("Code 49")] code49,
        [Description("Code 93")] code93,
        [Description("Code 93 Extended")] code93ext,
        [Description("Code One")] codeone,
        [Description("Compact Aztec Code")] azteccodecompact,
        [Description("Compact PDF417")] pdf417compact,
        [Description("Custom 1D symbology")] raw,
        [Description("Custom 4 state symbology")] daft,
        [Description("Data Matrix")] datamatrix,
        [Description("Data Matrix Rectangular")] datamatrixrectangular,
        [Description("Data Matrix Rectangular Extension")] datamatrixrectangularextension,
        [Description("Datalogic 2 of 5")] datalogic2of5,
        [Description("Deutsche Post Identcode")] identcode,
        [Description("Deutsche Post Leitcode")] leitcode,
        [Description("DotCode")] dotcode,
        [Description("EAN-13")] ean13,
        [Description("EAN-13 Composite")] ean13composite,
        [Description("EAN-2 (2 digit addon)")] ean2,
        [Description("EAN-5 (5 digit addon)")] ean5,
        [Description("EAN-8")] ean8,
        [Description("EAN-8 Composite")] ean8composite,
        [Description("Flattermarken")] flattermarken,
        [Description("GS1 Composite 2D Component")] gs1_cc,
        [Description("GS1 Data Matrix")] gs1datamatrix,
        [Description("GS1 Data Matrix Rectangular")] gs1datamatrixrectangular,
        [Description("GS1 DataBar Expanded")] databarexpanded,
        [Description("GS1 DataBar Expanded Composite")] databarexpandedcomposite,
        [Description("GS1 DataBar Expanded Stacked")] databarexpandedstacked,
        [Description("GS1 DataBar Expanded Stacked Composite")] databarexpandedstackedcomposite,
        [Description("GS1 DataBar Limited")] databarlimited,
        [Description("GS1 DataBar Limited Composite")] databarlimitedcomposite,
        [Description("GS1 DataBar Omnidirectional")] databaromni,
        [Description("GS1 DataBar Omnidirectional Composite")] databaromnicomposite,
        [Description("GS1 DataBar Stacked")] databarstacked,
        [Description("GS1 DataBar Stacked Composite")] databarstackedcomposite,
        [Description("GS1 DataBar Stacked Omnidirectional")] databarstackedomni,
        [Description("GS1 DataBar Stacked Omnidirectional Composite")] databarstackedomnicomposite,
        [Description("GS1 DataBar Truncated")] databartruncated,
        [Description("GS1 DataBar Truncated Composite")] databartruncatedcomposite,
        [Description("GS1 North American Coupon")] gs1northamericancoupon,
        [Description("GS1 QR Code")] gs1qrcode,
        [Description("GS1-128")] gs1_128,
        [Description("GS1-128 Composite")] gs1_128composite,
        [Description("GS1-14")] ean14,
        [Description("HIBC Aztec Code")] hibcazteccode,
        [Description("HIBC Codablock F")] hibccodablockf,
        [Description("HIBC Code 128")] hibccode128,
        [Description("HIBC Code 39")] hibccode39,
        [Description("HIBC Data Matrix")] hibcdatamatrix,
        [Description("HIBC Data Matrix Rectangular")] hibcdatamatrixrectangular,
        [Description("HIBC MicroPDF417")] hibcmicropdf417,
        [Description("HIBC PDF417")] hibcpdf417,
        [Description("HIBC QR Code")] hibcqrcode,
        [Description("Han Xin Code")] hanxin,
        [Description("IATA 2 of 5")] iata2of5,
        [Description("ISBN")] isbn,
        [Description("ISMN")] ismn,
        [Description("ISSN")] issn,
        [Description("ITF-14")] itf14,
        [Description("Industrial 2 of 5")] industrial2of5,
        [Description("Interleaved 2 of 5 (ITF)")] interleaved2of5,
        [Description("Italian Pharmacode")] code32,
        [Description("Japan Post 4 State Customer Code")] japanpost,
        [Description("MSI Modified Plessey")] msi,
        [Description("Matrix 2 of 5")] matrix2of5,
        [Description("MaxiCode")] maxicode,
        [Description("Micro QR Code")] microqrcode,
        [Description("MicroPDF417")] micropdf417,
        [Description("Miscellaneous symbols")] symbol,
        [Description("PDF417")] pdf417,
        [Description("Pharmaceutical Binary Code")] pharmacode,
        [Description("Pharmazentralnummer (PZN)")] pzn,
        [Description("Plessey UK")] plessey,
        [Description("PosiCode")] posicode,
        [Description("QR Code")] qrcode,
        [Description("Royal Dutch TPG Post KIX")] kix,
        [Description("Royal Mail 4 State Customer Code")] royalmail,
        [Description("Royal Mail Mailmark")] mailmark,
        [Description("SSCC-18")] sscc18,
        [Description("Telepen")] telepen,
        [Description("Telepen Numeric")] telepennumeric,
        [Description("Two-track Pharmacode")] pharmacode2,
        [Description("UPC-A")] upca,
        [Description("UPC-A Composite")] upcacomposite,
        [Description("UPC-E")] upce,
        [Description("UPC-E Composite")] upcecomposite,
        [Description("USPS Intelligent Mail")] onecode,
        [Description("USPS PLANET")] planet,
        [Description("USPS POSTNET")] postnet,
        [Description("Ultracode")] ultracode,
    }
}

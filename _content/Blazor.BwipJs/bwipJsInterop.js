// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

// bwip-js
// Create a barcode
export function create(canvasReference, option) {
    try {
        //console.log(JSON.stringify(option));
        // The return value is the canvas element
        let canvas = bwipjs.toCanvas(canvasReference, {
            bcid: option.barcodeType,           // Barcode type
            text: option.text,                  // Text to encode
            includetext: option.includeText,    // Show human-readable text
            textxalign: option.textXAlign,      
            textyalign: option.textYAlign,      
            scaleX: option.scaleX,              // Scaling factor
            scaleY: option.scaleY,              // Scaling factor
            rotate: option.rotate,              // Rotation
            height: option.height,              // Bar height, in millimeters
            width: option.width,                // Bar width, in millimeters
        });
    } catch (e) {
        // `e` may be a string or Error object
        console.log(e);
    }
}
/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Mozilla Universal charset detector code.
 *
 * The Initial Developer of the Original Code is
 * Netscape Communications Corporation.
 * Portions created by the Initial Developer are Copyright (C) 2001
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *          Kohei TAKETA <k-tak@void.in> (Java port)
 *          Rudi Pettazzi <rudi.pettazzi@gmail.com> (C# port)
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 *
 * ***** END LICENSE BLOCK ***** */

namespace Frost.SharpCharsetDetector.Models.SMModels {

    public class GB18030SMModel : SMModel {
        private static readonly int[] GB18030Cls = {
            BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1), // 00 - 07 
            BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 0, 0), // 08 - 0f 
            BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1), // 10 - 17 
            BitPackage.Pack4bits(1, 1, 1, 0, 1, 1, 1, 1), // 18 - 1f 
            BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1), // 20 - 27 
            BitPackage.Pack4bits(1, 1, 1, 1, 1, 1, 1, 1), // 28 - 2f 
            BitPackage.Pack4bits(3, 3, 3, 3, 3, 3, 3, 3), // 30 - 37 
            BitPackage.Pack4bits(3, 3, 1, 1, 1, 1, 1, 1), // 38 - 3f 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 40 - 47 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 48 - 4f 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 50 - 57 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 58 - 5f 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 60 - 67 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 68 - 6f 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 2), // 70 - 77 
            BitPackage.Pack4bits(2, 2, 2, 2, 2, 2, 2, 4), // 78 - 7f 
            BitPackage.Pack4bits(5, 6, 6, 6, 6, 6, 6, 6), // 80 - 87 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // 88 - 8f 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // 90 - 97 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // 98 - 9f 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // a0 - a7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // a8 - af 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // b0 - b7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // b8 - bf 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // c0 - c7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // c8 - cf 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // d0 - d7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // d8 - df 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // e0 - e7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // e8 - ef 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 6), // f0 - f7 
            BitPackage.Pack4bits(6, 6, 6, 6, 6, 6, 6, 0) // f8 - ff 
        };

        private static readonly int[] GB18030St = {
            BitPackage.Pack4bits(ERROR, START, START, START, START, START, 3, ERROR), //00-07 
            BitPackage.Pack4bits(ERROR, ERROR, ERROR, ERROR, ERROR, ERROR, ITSME, ITSME), //08-0f 
            BitPackage.Pack4bits(ITSME, ITSME, ITSME, ITSME, ITSME, ERROR, ERROR, START), //10-17 
            BitPackage.Pack4bits(4, ERROR, START, START, ERROR, ERROR, ERROR, ERROR), //18-1f 
            BitPackage.Pack4bits(ERROR, ERROR, 5, ERROR, ERROR, ERROR, ITSME, ERROR), //20-27 
            BitPackage.Pack4bits(ERROR, ERROR, START, START, START, START, START, START) //28-2f 
        };

        // To be accurate, the length of class 6 can be either 2 or 4. 
        // But it is not necessary to discriminate between the two since 
        // it is used for frequency analysis only, and we are validating 
        // each code range there as well. So it is safe to set it to be 
        // 2 here. 
        private static readonly int[] GB18030CharLenTable = {0, 1, 1, 1, 1, 1, 2};

        public GB18030SMModel() : base(
            new BitPackage(IndexShift.Shift4BITS, ShiftMask.Mask4BITS, BitShift.Shift4BITS, UnitMask.Mask4BITS, GB18030Cls),
            7,
            new BitPackage(IndexShift.Shift4BITS, ShiftMask.Mask4BITS, BitShift.Shift4BITS, UnitMask.Mask4BITS, GB18030St),
            GB18030CharLenTable,
            "GB18030",
            54936) {
        }
    }

}
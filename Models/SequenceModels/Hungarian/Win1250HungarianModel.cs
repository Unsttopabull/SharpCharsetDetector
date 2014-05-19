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
 *          Shy Shalom <shooshX@gmail.com>
 *          Rudi Pettazzi <rudi.pettazzi@gmail.com> (C# port)
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

namespace Frost.SharpCharsetDetector.Models.SequenceModels.Hungarian {

    public class Win1250HungarianModel : HungarianModel {
        private static readonly byte[] Win1250CharToOrderMap = {
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 254, 255, 255, 254, 255, 255, //00
            255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, //10
            +253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, 253, //20
            252, 252, 252, 252, 252, 252, 252, 252, 252, 252, 253, 253, 253, 253, 253, 253, //30
            253, 28, 40, 54, 45, 32, 50, 49, 38, 39, 53, 36, 41, 34, 35, 47,
            46, 72, 43, 33, 37, 57, 48, 64, 68, 55, 52, 253, 253, 253, 253, 253,
            253, 2, 18, 26, 17, 1, 27, 12, 20, 9, 22, 7, 6, 13, 4, 8,
            23, 67, 10, 5, 3, 21, 19, 65, 62, 16, 11, 253, 253, 253, 253, 253,
            161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176,
            177, 178, 179, 180, 78, 181, 69, 182, 183, 184, 185, 186, 187, 188, 189, 190,
            191, 192, 193, 194, 195, 196, 197, 76, 198, 199, 200, 201, 202, 203, 204, 205,
            81, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220,
            221, 51, 83, 222, 80, 223, 224, 225, 226, 44, 227, 228, 229, 61, 230, 231,
            232, 233, 234, 58, 235, 66, 59, 236, 237, 238, 60, 70, 63, 239, 240, 241,
            84, 14, 75, 242, 71, 82, 243, 73, 244, 15, 85, 79, 86, 30, 77, 87,
            245, 246, 247, 25, 74, 42, 24, 248, 249, 250, 31, 56, 29, 251, 252, 253
        };

        public Win1250HungarianModel() : base(Win1250CharToOrderMap, "windows-1250", 1250) {
        }
    }

}
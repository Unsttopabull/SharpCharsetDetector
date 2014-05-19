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

namespace Frost.SharpCharsetDetector.ContextAnalysers {

    public class EucJpContextAnalyser : JapaneseContextAnalyser {
        private const byte HIRAGANA_FIRST_BYTE = 0xA4;

        protected override int GetOrder(byte[] buf, int offset, out int charLen) {
            byte high = buf[offset];

            //find out current char's byte length
            if (high == 0x8E || high >= 0xA1 && high <= 0xFE) {
                charLen = 2;
            }
            else if (high == 0xBF) {
                charLen = 3;
            }
            else {
                charLen = 1;
            }

            // return its order if it is hiragana
            if (high == HIRAGANA_FIRST_BYTE) {
                byte low = buf[offset + 1];
                if (low >= 0xA1 && low <= 0xF3) {
                    return low - 0xA1;
                }
            }
            return -1;
        }

        protected override int GetOrder(byte[] buf, int offset) {
            // We are only interested in Hiragana
            if (buf[offset] == HIRAGANA_FIRST_BYTE) {
                byte low = buf[offset + 1];
                if (low >= 0xA1 && low <= 0xF3) {
                    return low - 0xA1;
                }
            }
            return -1;
        }
    }

}
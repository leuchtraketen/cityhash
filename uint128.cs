//
// Copyright (c) 2011 Google, Inc.
// Copyright (c) 2014 Gustavo J Knuppe (https://github.com/knuppe)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sub-license, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
// CityHash, by Geoff Pike and Jyrki Alakuijala
//
// Ported to C# by Gustavo J Knuppe (https://github.com/knuppe)
// 
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//   - May you do good and not evil.                                         -
//   - May you find forgiveness for yourself and forgive others.             -
//   - May you share freely, never taking more than you give.                -
//   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
//
// Project site: https://github.com/knuppe/cityhash
// Original code: https://code.google.com/p/cityhash/
//

using System;

namespace CityHash {
    /// <summary>
    /// Represents a 128-bit unsigned integer.
    /// </summary>
    public struct uint128 : IEquatable<uint128> {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:uint128"/> struct.
        /// </summary>
        public uint128(ulong low, ulong high)
            : this() {
            Low = low;
            High = high;
        }

        #region . Properties .

        #region . Low .
        /// <summary>
        /// Gets or sets the low-order 64-bits.
        /// </summary>
        /// <value>The low-order 64-bits.</value>
        public ulong Low { get; set; }
        #endregion

        #region . High .
        /// <summary>
        /// Gets or sets the high-order 64-bits.
        /// </summary>
        /// <value>The high-order 64-bits.</value>
        public ulong High { get; set; }
        #endregion

        #endregion

        #region . Equals .
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(uint128 other) {
            return Low == other.Low && High == other.High;
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <returns>
        /// true if <paramref name="obj"/> and this instance are the same type and represent the same value; otherwise, false.
        /// </returns>
        /// <param name="obj">Another object to compare to. </param>
        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uint128 && Equals((uint128)obj);
        }
        #endregion

        #region . GetHashCode .
        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>
        /// A 32-bit signed integer that is the hash code for this instance.
        /// </returns>
        public override int GetHashCode() {
            unchecked {
                return (Low.GetHashCode() * 397) ^ High.GetHashCode();
            }
        }
        #endregion

    }
}
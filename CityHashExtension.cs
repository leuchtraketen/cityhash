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

#if !NET20 // Framework v2.0 does not support extensions

using System;

namespace CityHash {
    /// <summary>
    /// Provides the CityHash string extensions.
    /// </summary>
    public static class CityHashExtension {

        /// <summary>
        /// Computes the 128-bit city hash for the specified string.
        /// This algorithm is tuned for strings of at least a few hundred bytes.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <returns>The 128-bit city hash.</returns>
        /// <exception cref="ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static uint128 GetCityHash128(this string value) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash128(value);
        }

        /// <summary>
        /// Computes the 128-bit city hash using a specific <paramref name="seed" />. 
        /// This algorithm is tuned for strings of at least a few hundred bytes.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="seed">Specifies the seed for the CityHash algorithm.</param>
        /// <returns>The 128-bit city hash.</returns>
        /// <exception cref="ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static uint128 GetCityHash128(this string value, uint128 seed) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash128(value, seed);
        }

        /// <summary>
        /// Computes the 32-bit city hash value for the specified string.
        /// </summary>
        /// <param name="value">The string to evaluate.</param>
        /// <returns>The computed 32-bit CityHash.</returns>
        /// <exception cref="System.ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static uint GetCityHash32(this string value) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash32(value);
        }

        /// <summary>
        /// Computes the 64-bit city hash value for the specified string.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <returns>The computed 64-bit CityHash.</returns>
        /// <exception cref="System.ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static ulong GetCityHash64(this string value) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash64(value);
        }

        /// <summary>
        /// Computes the 64-bit city hash value for the specified string using a specific <paramref name="seed" />.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="seed">Specifies the seed for the CityHash algorithm.</param>
        /// <returns>The computed 64-bit CityHash.</returns>
        /// <exception cref="System.ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static ulong GetCityHash64(this string value, ulong seed) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash64(value, seed);
        }

        /// <summary>
        /// Computes the 64-bit city hash value for the specified string using a low and high order 64-bit seeds.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="seed0">The low-order 64-bits seed used by the algorithm.</param>
        /// <param name="seed1">The high-order 64-bits seed used by the algorithm.</param>
        /// <returns>The computed 64-bit city hash.</returns>
        /// <exception cref="System.ArgumentNullException">value</exception>
        /// <remarks>This function encodes the string using the unicode block (ISO/IEC 8859-1).</remarks>
        public static ulong GetCityHash64(this string value, ulong seed0, ulong seed1) {
            if (value == null)
                throw new ArgumentNullException("value");

            return CityHash.CityHash64(value, seed0, seed1);
        }

        
    }
}
#endif
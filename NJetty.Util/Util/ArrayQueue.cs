﻿#region Apache License
//
// Licensed to the Apache Software Foundation (ASF) under one or more 
// contributor license agreements. See the NOTICE file distributed with
// this work for additional information regarding copyright ownership. 
// The ASF licenses this file to you under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with 
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NJetty.Util.Util
{

    /// <summary>
    /// TODO: Class/Interface Information here
    /// </summary>
    /// <author>  
    ///     <a href="mailto:leopoldo.agdeppa@gmail.com">Leopoldo Lee Agdeppa III</a>
    /// </author>
    /// <date>
    /// November 2008
    /// </date>
    public class ArrayQueue<E> : IList<E>
    {
        const int DEFAULT_CAPACITY = 64;
        const int DEFAULT_GROWTH = 32;
        object _lock = new object();
        object[] _elements;
        int _nextE;
        int _nextSlot;
        int _size;
        int _growCapacity;

        #region Constructors

        public ArrayQueue()
        {
            _elements = new object[DEFAULT_CAPACITY];
            _growCapacity = 32;
        }

        public ArrayQueue(int capacity)
        {
            _elements = new object[capacity];
            _growCapacity = -1;
        }

        /* ------------------------------------------------------------ */
        public ArrayQueue(int initCapacity, int growBy)
        {
            _elements = new object[initCapacity];
            _growCapacity = growBy;
        }

        /* ------------------------------------------------------------ */
        public ArrayQueue(int initCapacity, int growBy, object objectLock)
        {
            _elements = new object[initCapacity];
            _growCapacity = growBy;
            _lock = objectLock;
        }

        #endregion


        #region IList<E> Members

        public int IndexOf(E item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, E item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public E this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region ICollection<E> Members

        public void Add(E item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(E item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(E[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(E item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable<E> Members

        public IEnumerator<E> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
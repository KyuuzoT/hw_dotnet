﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Catalogue
{
    class File
    {
        protected string _name;
        protected Guid _idCode;
        protected string _category;
        protected long _size;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name could not be empty!");
                    Console.ResetColor();
                }
            }
        }

        public Guid ID
        {
            get
            {
                if (_idCode.Equals(Guid.Empty) || string.IsNullOrEmpty(_idCode.ToString()))
                {
                    return Guid.NewGuid();
                }

                return _idCode;
            }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    _idCode = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must set up a valid ID!");
                    Console.ResetColor();
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public long Size
        {
            get
            {
                return _size;
            }
            set
            {
                if(value > 0)
                {
                    _size = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Size can not be negative and must be greater than 0!");
                    Console.ResetColor();
                }
            }
        }

        public virtual string GetFileInformation()
        {
            string result = $"File type: {this.GetType()}\n" +
                $"File name: {this._name}\n" +
                $"File ID: {this._idCode}\n" +
                $"Category: {this._category}\n" +
                $"File size: {this._size}\n";
            return result;
        }
    }
}

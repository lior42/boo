﻿#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by
// astgenerator.boo on 2/28/04 8:05:40 a
//

namespace Boo.Lang.Ast.Impl
{
	using System;
	using Boo.Lang.Ast;
	
	[Serializable]
	public abstract class DeclarationImpl : Node
	{

		protected string _name;
		protected TypeReference _type;

		protected DeclarationImpl()
		{
			InitializeFields();
		}
		
		protected DeclarationImpl(LexicalInfo info) : base(info)
		{
			InitializeFields();
		}
		

		protected DeclarationImpl(string name, TypeReference type)
		{
			InitializeFields();
			Name = name;
			Type = type;
		}
			
		protected DeclarationImpl(LexicalInfo lexicalInfo, string name, TypeReference type) : base(lexicalInfo)
		{
			InitializeFields();
			Name = name;
			Type = type;
		}
			
		new public Boo.Lang.Ast.Declaration CloneNode()
		{
			return Clone() as Boo.Lang.Ast.Declaration;
		}

		override public NodeType NodeType
		{
			get
			{
				return NodeType.Declaration;
			}
		}
		
		override public void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Boo.Lang.Ast.Declaration thisNode = (Boo.Lang.Ast.Declaration)this;
			Boo.Lang.Ast.Declaration resultingTypedNode = thisNode;
			transformer.OnDeclaration(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}

		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}

			if (_type == existing)
			{
				this.Type = ((Boo.Lang.Ast.TypeReference)newNode);
				return true;
			}

			return false;
		}

		override public object Clone()
		{
			Boo.Lang.Ast.Declaration clone = (Boo.Lang.Ast.Declaration)System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Boo.Lang.Ast.Declaration));
			clone._lexicalInfo = _lexicalInfo;
			clone._documentation = _documentation;
			clone._properties = (System.Collections.Hashtable)_properties.Clone();
			

			clone._name = _name;

			if (null != _type)
			{
				clone._type = ((TypeReference)_type.Clone());
			}
			
			return clone;
		}
			
		public string Name
		{
			get
			{
				return _name;
			}
			

			set
			{
				_name = value;
			}

		}
		

		public TypeReference Type
		{
			get
			{
				return _type;
			}
			

			set
			{
				if (_type != value)
				{
					_type = value;
					if (null != _type)
					{
						_type.InitializeParent(this);

					}
				}
			}
			

		}
		

		private void InitializeFields()
		{

		}
	}
}

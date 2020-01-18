﻿namespace BCA.WerZaehltWo3.ObjectModel
{
    using System;
    using System.Xml;

    using BCA.WerZaehltWo3.Common;

    public class Player : BaseObject
    {
        public Player()
        {
            this.InternalClear();
        }

        public Player(string name) : this()
        {
            this.Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Club { get; set; }

        public string Category { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals((Player)obj);
        }

        public bool Equals(Player other)
        {
            if (other == null)
            {
                return false;
            }

            if (!string.Equals(this.Name, other.Name))
            {
                return false;
            }

            if (!string.Equals(this.Club, other.Club))
            {
                return false;
            }

            if (!string.Equals(this.Category, other.Category))
            {
                return false;
            }

            if (!string.Equals(this.Id, other.Id))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            var result = 0;

            if (this.Name != null)
            {
                result = result ^ this.Name.GetHashCode();
            }

            if (this.Club != null)
            {
                result = result ^ this.Club.GetHashCode();
            }

            if (this.Category != null)
            {
                result = result ^ this.Category.GetHashCode();
            }

            if (this.Id != null)
            {
                result = result ^ this.Id.GetHashCode();
            }

            return result;
        }

        public override void Clear()
        {
            this.InternalClear();
        }

        public Player Clone()
        {
            var result = new Player();
            result.CopyFrom(this);
            return result;
        }

        public void CopyFrom(Player other)
        {
            this.Name = other.Name;
            this.Club = other.Club;
            this.Category = other.Category;
            this.Id = other.Id;
        }

        public override void Load(XmlNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            this.InternalClear();

            this.Id = XmlHelper.LoadAttribute(node, "id", this.Id);
            this.Name = XmlHelper.LoadAttribute(node, "name", this.Name);
            this.Club = XmlHelper.LoadAttribute(node, "club", this.Club);
            this.Category = XmlHelper.LoadAttribute(node, "category", this.Category);
        }

        public override string Save()
        {
            var result = "<Player ";
            result += XmlHelper.SaveAttribute("id", this.Id) + " ";
            result += XmlHelper.SaveAttribute("name", this.Name) + " ";
            result += XmlHelper.SaveAttribute("category", this.Category) + " ";
            result += XmlHelper.SaveAttribute("club", this.Club) + " />";
            return result;
        }

        private void InternalClear()
        {
            this.Id = null;
            this.Name = null;
            this.Club = null;
            this.Category = null;
        }
    }
}
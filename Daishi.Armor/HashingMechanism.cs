﻿#region Includes

using System;
using System.Security.Cryptography;

#endregion

namespace Daishi.Armor {
    public abstract class HashingMechanism : ICommand {
        protected readonly byte[] key;
        private readonly byte[] input;

        public object Result { get { return Output; } }
        public string Output { get; private set; }
        public string Hash { get; private set; }

        protected HashingMechanism(byte[] key, byte[] input) {
            this.key = key;
            this.input = input;
        }

        public abstract void Execute();

        public void Undo() {
            throw new NotImplementedException();
        }

        protected void ComputeHash(HMAC hmac) {
            var hashed = hmac.ComputeHash(input);
            var output = new byte[hashed.Length + input.Length];

            Buffer.BlockCopy(hashed, 0, output, 0, hashed.Length);
            Buffer.BlockCopy(input, 0, output, hashed.Length, input.Length);

            Output = Convert.ToBase64String(output);
            Hash = Convert.ToBase64String(hashed);
        }
    }
}